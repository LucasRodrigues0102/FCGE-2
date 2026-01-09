using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCGE
{
    public class Item
    {
        private string nome;
        public int quantidade;
        private double preco;
        private double custo;

        public Item()
        {
            this.nome = "Desconhecido";
            this.quantidade = 0;
            this.preco = 0.0;
            this.custo = 0.0;
        }

        public void setDados(string nome, int quantidade, double preco, double custo)
        {
            this.nome = nome;
            
            if (quantidade > 0)
            {
                this.quantidade = quantidade;

            }

            else
            {
                throw new ArgumentException("Quantidade inválida!");
            }
            
            if (preco > 0)
            {
                this.preco = preco;
            }

            else
            {
                throw new ArgumentException("Preço inválido!");
            }

            if (custo >= 0)
            {
                this.custo = custo;
            }

            else
            {
                throw new ArgumentException("Custo inválido!");
            }
        }

        public string getNome()
        {
            return this.nome;
        }

        public int getQuantidade()
        {
            return this.quantidade;
        }

        public double getPreco()
        {
            return this.preco;
        }

        public double getCusto()
        {
            return this.custo;
        }
    }
}