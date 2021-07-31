using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Database.Modelos;
using System.Data;

namespace Database
{
    public class ContactRepository
    {
        private SqlConnection _connection;
        public ContactRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Add(Contact item)
        {
            SqlCommand command = new SqlCommand("insert into Contacts(Name,LastName,Phone,IdContactType) values(@name,@lastname,@phone,@idcontacttype)", _connection);

            command.Parameters.AddWithValue("@name", item.Name);
            command.Parameters.AddWithValue("@lastname", item.LastName);
            command.Parameters.AddWithValue("@phone", item.Phone);
            command.Parameters.AddWithValue("@idcontacttype", item.IdContactType);            

            return ExecuteDml(command);
        }

        public bool Edit(Contact item)
        {
            SqlCommand command = new SqlCommand("update Contacts set Name=@name,LastName=@lastname,Phone=@phone,IdContactType = @idcontacttype where Id = @id", _connection);

            command.Parameters.AddWithValue("@name", item.Name);
            command.Parameters.AddWithValue("@lastname", item.LastName);
            command.Parameters.AddWithValue("@phone", item.Phone);
            command.Parameters.AddWithValue("@idcontacttype", item.IdContactType);
            command.Parameters.AddWithValue("@id", item.Id);            

            return ExecuteDml(command);
        }

        public bool Delete(int id)
        {
            SqlCommand command = new SqlCommand("delete Contacts where Id = @id", _connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }

        public Contact GetById(int id)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("Select c.Id,c.Name,c.LastName,c.Phone,ct.Name as TipoContacto from Contacts c join ContactTypes ct on c.IdContactType = ct.Id where c.Id = @id", _connection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                Contact data = new Contact();

                while (reader.Read())
                {
                    data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Name = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    data.LastName = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Phone = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    data.TipoContacto = reader.IsDBNull(4) ? "" : reader.GetString(4);
                }

                reader.Close();
                reader.Dispose();

                _connection.Close();

                return data;               
            }
            catch(Exception e)
            {
                return null;
            }
          
        }

        public DataTable GetAll()
        {
            SqlDataAdapter query = new SqlDataAdapter("select c.Id as Codigo,c.Name as Nombre,c.LastName as Apellido,c.Phone as Telefono,ct.Name as TipoContacto from Contacts c join ContactTypes ct on c.IdContactType = ct.Id", _connection);
            return LoadData(query);
        }

        private DataTable LoadData(SqlDataAdapter query)
        {
            try
            {
                DataTable data = new DataTable();

                _connection.Open();

                query.Fill(data);

                _connection.Close();

                return data;
            }
            catch (Exception e)
            {
                return null;
            }

        }
        private bool ExecuteDml(SqlCommand query)
        {
            try
            {
                _connection.Open();

                query.ExecuteNonQuery();

                _connection.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

    }
}
