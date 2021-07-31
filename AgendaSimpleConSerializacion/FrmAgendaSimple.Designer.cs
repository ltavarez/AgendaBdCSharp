
namespace AgendaSimpleConSerializacion
{
    partial class FrmAgendaSimple
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblPhone = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.DgvContactos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnDeselect = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.LblContactType = new System.Windows.Forms.Label();
            this.CbxContactType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvContactos)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.875F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DgvContactos, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.888889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.53571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(841, 560);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.menuStrip1, 3);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSessionToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // cerrarSessionToolStripMenuItem
            // 
            this.cerrarSessionToolStripMenuItem.Name = "cerrarSessionToolStripMenuItem";
            this.cerrarSessionToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.cerrarSessionToolStripMenuItem.Text = "Cerrar session";
            this.cerrarSessionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSessionToolStripMenuItem_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.TxtLastName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.LblName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LblLastName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LblPhone, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.TxtName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxtPhone, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.BtnSave, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.LblContactType, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.CbxContactType, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(212, 41);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(424, 183);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtLastName.Location = new System.Drawing.Point(215, 39);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(206, 23);
            this.TxtLastName.TabIndex = 4;
            // 
            // LblName
            // 
            this.LblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblName.Location = new System.Drawing.Point(132, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(77, 21);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Nombre:";
            // 
            // LblLastName
            // 
            this.LblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLastName.AutoSize = true;
            this.LblLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblLastName.Location = new System.Drawing.Point(130, 36);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(79, 21);
            this.LblLastName.TabIndex = 1;
            this.LblLastName.Text = "Apellido:";
            // 
            // LblPhone
            // 
            this.LblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPhone.AutoSize = true;
            this.LblPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPhone.Location = new System.Drawing.Point(128, 72);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(81, 21);
            this.LblPhone.TabIndex = 2;
            this.LblPhone.Text = "Telefono:";
            // 
            // TxtName
            // 
            this.TxtName.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtName.Location = new System.Drawing.Point(215, 3);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(206, 23);
            this.TxtName.TabIndex = 3;
            // 
            // BtnSave
            // 
            this.BtnSave.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.BtnSave, 2);
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSave.Location = new System.Drawing.Point(3, 147);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(418, 33);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // DgvContactos
            // 
            this.DgvContactos.AllowUserToAddRows = false;
            this.DgvContactos.AllowUserToDeleteRows = false;
            this.DgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvContactos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvContactos.Location = new System.Drawing.Point(212, 230);
            this.DgvContactos.MultiSelect = false;
            this.DgvContactos.Name = "DgvContactos";
            this.DgvContactos.ReadOnly = true;
            this.DgvContactos.RowTemplate.Height = 25;
            this.DgvContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvContactos.Size = new System.Drawing.Size(424, 277);
            this.DgvContactos.TabIndex = 2;
            this.DgvContactos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvContactos_CellClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.BtnDeselect, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnDelete, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(212, 513);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(424, 44);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // BtnDeselect
            // 
            this.BtnDeselect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDeselect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDeselect.Location = new System.Drawing.Point(215, 3);
            this.BtnDeselect.Name = "BtnDeselect";
            this.BtnDeselect.Size = new System.Drawing.Size(206, 38);
            this.BtnDeselect.TabIndex = 1;
            this.BtnDeselect.Text = "Deseleccionar";
            this.BtnDeselect.UseVisualStyleBackColor = true;
            this.BtnDeselect.Visible = false;
            this.BtnDeselect.Click += new System.EventHandler(this.BtnDeselect_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDelete.Location = new System.Drawing.Point(3, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(206, 38);
            this.BtnDelete.TabIndex = 0;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxtPhone
            // 
            this.TxtPhone.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtPhone.Location = new System.Drawing.Point(215, 75);
            this.TxtPhone.Mask = "(999) 000-0000";
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(206, 23);
            this.TxtPhone.TabIndex = 7;
            // 
            // LblContactType
            // 
            this.LblContactType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblContactType.AutoSize = true;
            this.LblContactType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblContactType.Location = new System.Drawing.Point(67, 108);
            this.LblContactType.Name = "LblContactType";
            this.LblContactType.Size = new System.Drawing.Size(142, 21);
            this.LblContactType.TabIndex = 8;
            this.LblContactType.Text = "Tipo de contacto:";
            // 
            // CbxContactType
            // 
            this.CbxContactType.Dock = System.Windows.Forms.DockStyle.Top;
            this.CbxContactType.FormattingEnabled = true;
            this.CbxContactType.Location = new System.Drawing.Point(215, 111);
            this.CbxContactType.Name = "CbxContactType";
            this.CbxContactType.Size = new System.Drawing.Size(206, 23);
            this.CbxContactType.TabIndex = 9;
            // 
            // FrmAgendaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 560);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmAgendaSimple";
            this.Text = "Agenda simple";
            this.Load += new System.EventHandler(this.FrmAgendaSimple_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvContactos)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSessionToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.DataGridView DgvContactos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BtnDeselect;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.MaskedTextBox TxtPhone;
        private System.Windows.Forms.Label LblContactType;
        private System.Windows.Forms.ComboBox CbxContactType;
    }
}

