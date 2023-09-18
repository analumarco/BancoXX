using BancoXX.classes;
using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o tipo de conta:" +
            "\n1. Conta empresarial" +
            "\n2. Conta estudante");
        int opcao = Convert.ToInt32(Console.ReadLine());

        while (true)
        {
            switch (opcao)
            {
                case 1:
                    ContaEmpresarial e = new ContaEmpresarial();
                    e.NumeroConta = 1234;
                    e.Agencia = "12345";
                    e.Titular = "Pedrocas";
                    e.Saldo = 5000;
                    e.Anuidade = 5;
                    e.LimiteEmprestimo = 300;
                    e.TotalEmprestimo = 0;

                    Console.WriteLine("Qual operação deseja fazer?" +
                        "\n1. Empréstimo" +
                        "\n2. Saque" +
                        "\n3. Depósito");
                    int operacao = Convert.ToInt32(Console.ReadLine());
                    if (operacao == 1)
                    {
                        Console.WriteLine("Digite o valor do empréstimo:");
                        int valorE = Convert.ToInt32(Console.ReadLine());
                        e.FazerEmprestimo(valorE);
                    }
                    else if (operacao == 2)
                    {
                        Console.WriteLine("Digite o valor do saque:");
                        int valorS = Convert.ToInt32(Console.ReadLine());
                        e.Sacar(valorS);
                    }
                    else if (operacao == 3)
                    {
                        Console.WriteLine("Digite o valor do depósito:");
                        int valorD = Convert.ToInt32(Console.ReadLine());
                        e.Depositar(valorD);
                    }
                    else
                    {
                        Console.WriteLine("Número inválido!");
                    }
                    break;

                case 2:
                    ContaEstudante s = new ContaEstudante();
                    s.NumeroConta = 5678;
                    s.Agencia = "12345";
                    s.Titular = "Aninha";
                    s.Saldo = 500;
                    s.LimiteChequeEspecial = 300;
                    s.Cpf = "04338964260";
                    s.NomeInstituicao = "Instituto Federal de Rondônia";

                    Console.WriteLine("Qual operação deseja fazer?" +
                        "\n1. Saque" +
                        "\n2. Depósito");
                    int ope = Convert.ToInt32(Console.ReadLine());

                    if (ope == 1)
                    {
                        Console.WriteLine("Digite o valor do saque:");
                        int valorS = Convert.ToInt32(Console.ReadLine());
                        s.Sacar(valorS);
                    }
                    else if (ope == 2)
                    {
                        Console.WriteLine("Digite o valor do depósito:");
                        int valorD = Convert.ToInt32(Console.ReadLine());
                        s.Depositar(valorD);
                    }
                    else
                    {
                        Console.WriteLine("Número inválido!");
                    }

                    break;
            }
        }
        /*
        Conta c = new Conta();
        c.NumeroConta = 0123;
        c.Agencia = "0114";
        c.Titular = "Ana Luísa";
        c.Saldo = 500;

        Console.WriteLine(c.Saldo);

        Console.WriteLine("Digite o valor para deposito");
        double valorS  = Convert.ToDouble(Console.ReadLine());
        c.Sacar(valorS);



        Console.WriteLine("Digete o valor de deposito");
        valorS  = Convert.ToDouble(Console.ReadLine());

        c.Depositar(valorS);
        */
        Console.ReadKey();
    }
}