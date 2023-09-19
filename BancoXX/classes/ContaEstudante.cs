using System;
using System.Collections.Generic;
using System.Drawing;
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
            double saldo = saque + LimiteChequeEspecial;
            if(saque > saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
            }
            else
            {
                Saldo = Saldo - saque;
                Console.WriteLine($"Você finalizou seu saque!" +
                    $"\nR${saque.ToString("F2")} foram sacados, valor na conta: R${Saldo.ToString("F2")}.");
            }
        }

    }
}
