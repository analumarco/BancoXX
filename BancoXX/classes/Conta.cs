using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoXX.classes
{
    internal class Conta
    {
        public int NumeroConta { get; set; }
        public string Agencia { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public virtual void Sacar (double valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
            }
            else
            {
                double valorFinal = Saldo - valor;
                Console.WriteLine($"Você finalizou seu saque!" +
                    $"\nR${valor.ToString("F2")} foram sacados, valor na conta: R${valorFinal.ToString("F2")}.");
                Saldo = valorFinal;

            }

        }

        public void Depositar (double dep)
        {
            Saldo = Saldo + dep;
            Console.WriteLine("Valor total após o depósito: R$" + Saldo);
        }
    }
}
