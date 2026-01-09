using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCGE
{
    public class Login
    {
        private List<User> lista_user;
        public Login()
        {
            lista_user = new List<User>();
        }

        public void adicionarUser(User user)
        {
            lista_user.Add(user);
        }

        public User pesquisarUser(string nome, string senha)
        {
            foreach (User user in lista_user)
            {
                if (user.getNome() == nome && user.getSenha() == senha)
                {
                    return user;
                }
            }

            return null;
        }
    }
}
