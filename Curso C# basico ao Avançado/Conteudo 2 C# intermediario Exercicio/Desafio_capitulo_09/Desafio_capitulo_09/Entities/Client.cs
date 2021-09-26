using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_capitulo_09.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Data { get; set; }


        public Client(string name, string email, DateTime date)
        {
            Name = name;
            Email = email;
            Data = date;
        }

        public override string ToString()
        {
            return Name + " " + Data.ToString("dd/mm/yyyy") + "  " + Email;
        }
    }
}
