using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCGE
{
    public class Estoque
    {
        private List<Item> lista_item;

        public Estoque()
        {
            lista_item = new List<Item>();
        }
        public void adicionarItem(Item item)
        {
            lista_item.Add(item);
        }

        public void removerItem(Item item)
        {
            lista_item.Remove(item);
        }

        public Item pesquisarItem(string nome)
        {
            foreach (Item item in lista_item)
            {
                if (item.getNome() == nome)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
