using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCGE
{
    public class User
    {
        private string nome;
        private string senha;

        public User()
        {
            this.nome = "Desconhecido";
            this.senha = "Desconhecida";
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setSenha(string senha)
        {
            this.senha=senha;
        }
        public string getSenha()
        {
            return this.senha;
        }
    }
}
