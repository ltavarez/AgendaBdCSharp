using Database;
using Database.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace BusinessLayer
{
    public class ContactTypeService
    {

        private ContactTypeRepository _repository;

        public ContactTypeService(SqlConnection connection)
        {
            _repository = new ContactTypeRepository(connection);
        }

        public List<ContactType> GetList()
        {
            return _repository.GetList();
        }
            
    }
}
