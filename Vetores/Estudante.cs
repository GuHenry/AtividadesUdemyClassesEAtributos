using System;
using System.Collections.Generic;
using System.Text;

namespace Vetores
{
    public class Estudante
    {
        public Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
