using System;
using System.Collections.Generic;
using System.Text;

namespace EnumsEComposicao.Entities
{
    public class Client
    {
        public Client()
        {

        }
        public Client(string name, string email, DateTime date)
        {
            Name = name;
            Email = email;
            Date = date;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
    }
}
