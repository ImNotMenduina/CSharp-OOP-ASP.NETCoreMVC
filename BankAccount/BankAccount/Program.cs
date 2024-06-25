using BankAccount;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número da conta: ");
            int accNumber = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string client = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string op = Console.ReadLine();

            Account acc;

            if (op == "s" || op == "S")
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                 acc = new(accNumber, client, initialDeposit);
            }
            else
            {
                 acc = new(accNumber, client);
            }

            Console.WriteLine($"\nDados da conta:\n{acc}");

            Console.Write("Entre com um valor para depósito: ");
            acc.Deposit(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine($"Dados da conta atualizados:\n{acc}");

            Console.Write("Entre um valor para saque: ");
            acc.Withdraw(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine($"Dados da conta atualizados:\n{acc}");

        }
    }
}