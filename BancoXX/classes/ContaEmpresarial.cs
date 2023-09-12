using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoXX.classes
{
    internal class ContaEmpresarial:Conta
    {
        public double Anuidade { get; set; }
        public double LimiteEmprestimo { get; set; }
        public double TotalEmprestimo { get; set; }

        public void FazerEmprestimo(double emp)
        {
            if(emp > LimiteEmprestimo)
            {
                Console.WriteLine("Limite de empréstimo excedido!");
            }
            else
            {
                TotalEmprestimo = LimiteEmprestimo - emp;
                Saldo = Saldo - emp;
                Console.WriteLine($"Empréstimo realizado!" +
                    $"\nVocê tem um total de {TotalEmprestimo.ToString("F2")} de limite.");
            }
        }

        public override void Sacar(double saque)
        {
            if(saque > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para o saque!");
            }
            else
            {
                if(saque >= 5000)
                {
                    saque = saque + 5;
                    Saldo = Saldo - saque;
                    Console.WriteLine("Saque realizado! Taxa cobrada: R$5,00");
                }
                else
                {
                    Saldo = Saldo - saque;
                    Console.WriteLine("Saque realizado!");
                }
            }
        }
    }
}
