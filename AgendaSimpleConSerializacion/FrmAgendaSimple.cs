using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaSimpleConSerializacion.CustomControlItem;
using BusinessLayer;
using Database.Modelos;

namespace AgendaSimpleConSerializacion
{
    public partial class FrmAgendaSimple : Form
    {

        private ServicioContacto _servicio;
        private ContactTypeService _contactTypeService;
        public int? id = null;
        public FrmAgendaSimple()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _servicio = new ServicioContacto(connection);
            _contactTypeService = new ContactTypeService(connection);
        }

        #region Eventos

        private void cerrarSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cerrar", "notificacion");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (id == null)
            {
                AddContacto();
            }
            else
            {
                EditContacto();
            }

        }
        private void FrmAgendaSimple_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBox();
        }

        private void DgvContactos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = Convert.ToInt32(DgvContactos.Rows[e.RowIndex].Cells[0].Value.ToString());
                BtnDeselect.Visible = true;

                Contact contact = new Contact();

                contact = _servicio.GetById(id.Value);

                TxtName.Text = contact.Name;
                TxtLastName.Text = contact.LastName;
                TxtPhone.Text = contact.Phone;

                if (string.IsNullOrEmpty(contact.TipoContacto))
                {
                    CbxContactType.SelectedIndex = 0;
                }
                else
                {
                    CbxContactType.SelectedIndex = CbxContactType.FindStringExact(contact.TipoContacto);
                }
               
            }
        }

        private void BtnDeselect_Click(object sender, EventArgs e)
        {

            Deselect();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteContact();
        }

        #endregion

        #region "Metodos privados"

        private void AddContacto()
        {
            ComboBoxItem selectedItem = CbxContactType.SelectedItem as ComboBoxItem;

            if(selectedItem.Value != null)
            {
                Contact contact = new Contact();
                contact.Name = TxtName.Text;
                contact.LastName = TxtLastName.Text;
                contact.Phone = TxtPhone.Text;
                contact.IdContactType = Convert.ToInt32(selectedItem.Value);

                bool result = _servicio.Add(contact);

                if (result)
                {
                    MessageBox.Show("Se ha creado con exito", "Notificacion");
                }
                else
                {
                    MessageBox.Show("Oopss ha ocurrido un error", "Notificacion");
                }


                LoadData();
                ClearData();
                Deselect();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de contacto", "Notificacion");
            }

            
        }

        private void LoadComboBox()
        {

            ComboBoxItem opcionPorDefecto = new ComboBoxItem
            {
                Text = "Selecciona una opcion",
                Value = null
            };

            CbxContactType.Items.Add(opcionPorDefecto);

            List<ContactType> listType = _contactTypeService.GetList();

            foreach (ContactType item in listType)
            {
                ComboBoxItem comboItem = new ComboBoxItem
                {
                    Text = item.Name,
                    Value = item.Id
                };
                CbxContactType.Items.Add(comboItem);

            }

            CbxContactType.SelectedItem = opcionPorDefecto;

        }

        private void EditContacto()
        {

            ComboBoxItem selectedItem = CbxContactType.SelectedItem as ComboBoxItem;

            if (selectedItem.Value != null)
            {
                Contact contact = new Contact();
                contact.Name = TxtName.Text;
                contact.LastName = TxtLastName.Text;
                contact.Phone = TxtPhone.Text;
                contact.Id = id.Value;
                contact.IdContactType = Convert.ToInt32(selectedItem.Value);

                bool result = _servicio.Edit(contact);
                if (result)
                {
                    MessageBox.Show("Se ha editado con exito", "Notificacion");
                }
                else
                {
                    MessageBox.Show("Oopss ha ocurrido un error", "Notificacion");
                }

                LoadData();
                ClearData();
                Deselect();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de contacto", "Notificacion");
            }
        }

        private void LoadData()
        {
            DgvContactos.DataSource = _servicio.GetAll();
            DgvContactos.ClearSelection();
        }

        private void ClearData()
        {
            TxtName.Clear();
            TxtLastName.Clear();
            TxtPhone.Clear();

            CbxContactType.SelectedIndex = 0;
        }

        private void Deselect()
        {
            DgvContactos.ClearSelection();
            BtnDeselect.Visible = false;
            id = null;
            ClearData();
        }

        private void DeleteContact()
        {
            if (id == null)
            {
                MessageBox.Show("Debes seleccionar un contacto", "Notificacion");
            }
            else
            {
                DialogResult response = MessageBox.Show("Esta seguro que desea eliminar este contacto",
                    "Advertencia", MessageBoxButtons.OKCancel);

                if (response == DialogResult.OK)
                {
                    bool result = _servicio.Delete(id.Value);

                    if (result)
                    {
                        MessageBox.Show("Se ha eliminado con exito", "Notificacion");
                    }
                    else
                    {
                        MessageBox.Show("Oopss ha ocurrido un error", "Notificacion");
                    }
                    LoadData();
                    Deselect();
                }

            }
        }



        #endregion

    }
}
