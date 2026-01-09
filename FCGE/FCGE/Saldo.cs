using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCGE
{
    public class Saldo
    {
        private double saldo;

        public Saldo()
        {
            this.saldo = 0.0;
        }

        public void AdicionarSaldo(double valor)
        {
            if (valor > 0)
            {
                this.saldo += valor;
            }
            
            else
            {
                throw new ArgumentException("Digite um valor válido acima de 0!");
            }
        }

        public void SubtrairSaldo(double valor)
        {
            if (valor > 0)
            {
                this.saldo -= valor;
            }

            else
            {
                throw new ArgumentException("Digite um valor válido acima de 0!");
            }
        }

        public void CustoFabSaldo(int quantidade, double valor)
        {
            this.saldo -= quantidade * valor;
        }

        public double GetSaldo()
        {
            return this.saldo;
        }
    }
}
