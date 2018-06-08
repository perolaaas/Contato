using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contato1
{
    class Contato
    {
        //atributos
        private string email;
        private string nome;
        private string telefone;

        //propriedades
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        //construtores
        public Contato(string email, string nome, string telefone)
        {
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
        }

        public Contato(): this("", "", "")
        {
        }

        public override bool Equals(object obj)
        {
            Contato c = ((Contato)obj);
            return Email.Equals(c.Email);
        }

    }//class
}//namespace
