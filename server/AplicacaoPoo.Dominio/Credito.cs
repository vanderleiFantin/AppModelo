using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio
{
    public class Credito
    {
        Pagamento Pagamento { get; set; }
        int Parcelas { get; set; }
        float Juros { get; set; }

        public double CreditarValor(double saldo, double credito)
        {
            var resultado = saldo + credito;
            return resultado;

        }
    }
}
