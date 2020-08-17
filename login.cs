using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.regranegocio
{
    class login
    {
        private string nome;
        private string email;
        private string senha;
        private string telefone;
        private string endereco;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public void ExcluirContato()
        {
            try
            {
                dal.comandoSQL("DELETE FROM tbContato where codigo " + Codigo + "");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
