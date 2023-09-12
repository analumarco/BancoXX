using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoXX.classes
{
    internal class ContaEstudante:Conta
    {
        public double LimiteChequeEspecial { get; set; }
        public string Cpf { get; set; }
        public string NomeInstituicao { get; set; } 

        public override void Sacar(double saque)
        {
            double saldo = Saldo + LimiteChequeEspecial;
            if(saque > saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
            }
            else
            {
                Saldo = Saldo - saldo;
                Console.WriteLine("Saque realizado!");
            }
        }

    }
}
