using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContatos
{
   public class Contato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string NumTelefone { get; set; }

        public Contato(string nome = "", string email = "", string numTelefone = "")
        {
            this.Nome = nome;
            this.Email = email;
            this.NumTelefone = numTelefone;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}, {2}", this.Nome, this.Email, this.NumTelefone);
        }


    }
}
