using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma.modelo
{
    internal class Controle : Propriedades
    {
        public Controle(string numero1, string numero2, string tipoConta)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
            this.tipoConta = tipoConta;
            Executar();
        }

        private void Executar()
        {
            mensagem = "";
            Validacao validacao = new Validacao(this.numero1, this.numero2, tipoConta);
            if (validacao.Mensagem.Equals(""))
            {
                Calculos calculos = new Calculos(validacao.N1, validacao.N2, validacao.tipoConta);
                resultado = calculos.Res.ToString();
            }
            else
            {
                mensagem = validacao.Mensagem;
            }
        }
    }
}
