using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma.modelo
{
    internal class Calculos : Propriedades
    {
        public Calculos(double n1, double n2, string tipoConta)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.tipoConta = tipoConta;
            Calcular();
        }

        private void Calcular()
        {
            if(tipoConta.Equals("Somar"))
            {
                this.res = this.n1 + this.n2;
            }
            else if(tipoConta.Equals("Subtrair"))
            {
                this.res = this.n1 - this.n2;
            }
            else if(tipoConta.Equals("Dividir"))
            {
                this.res = this.n1 / this.n2;
            }
            else if(tipoConta.Equals("Multiplicar"))
            {
                this.res = this.n1 * this.n2;
            }
            
        }
    }
}
