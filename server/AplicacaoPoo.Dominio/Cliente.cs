using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio
{
    //Criar um novo formulário frmCliente
    //Adicionar 4 textbox e 4 Label para
    // Nome, CPF, Valor de debito, Valor de credito
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get;set; }
        public double SaldoInicial { get; set; }
        public Debito Debito{ get; set; }
        public Credito Credito{ get; set; }
    }
}
