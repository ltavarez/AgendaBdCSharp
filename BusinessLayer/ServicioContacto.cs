using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Database.Modelos;
using Database;
using System.Data;

namespace BusinessLayer
{
    public class ServicioContacto
    {
        private ContactRepository repository;
        public ServicioContacto(SqlConnection connection)
        {
            repository = new ContactRepository(connection);
        }

        public bool Add(Contact item)
        {
            return repository.Add(item);
        }

        public bool Edit(Contact item)
        {
            return repository.Edit(item);
        }

        public bool Delete(int id)
        {
            return repository.Delete(id);
        }

        public Contact GetById(int id)
        {
            return repository.GetById(id);
        }

        public DataTable GetAll()
        {
            return repository.GetAll();
        }
    }
}
