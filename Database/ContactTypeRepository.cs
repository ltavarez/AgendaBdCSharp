using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Database.Modelos;

namespace Database
{
    public class ContactTypeRepository
    {
        private SqlConnection _connection;
        public ContactTypeRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<ContactType> GetList()
        {
            try
            {
                List<ContactType> list = new List<ContactType>();
                _connection.Open();

                SqlCommand command = new SqlCommand("Select Id,Name from ContactTypes", _connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new ContactType
                    {
                        Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        Name = reader.IsDBNull(1) ? "" : reader.GetString(1),
                    });
                }

                reader.Close();
                reader.Dispose();

                _connection.Close();

                return list;

            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
