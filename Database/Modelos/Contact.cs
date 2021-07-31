using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Modelos
{
    public class Contact
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public int IdContactType { get; set; }

        public string TipoContacto { get; set; }
    }
}
