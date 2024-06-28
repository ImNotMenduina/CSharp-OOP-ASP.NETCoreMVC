using Acc.Entities;
using System.Globalization;
using System;


//Sobreposição : é a implementação de um método de uma superclasse na subclasse;

//Para que um método comum(não abstrato) possa ser sobreposto, deve ser incluído nele o prefixo "virtual"

//Ao sobrescrever um método, devemos incluir nele o prefixo "override"

//base (chama a implementação da superclasse); 

//Saque em conta comum : taxa no valor de 5.00 reais
//Saque conta poupança : não é cobrado taxa

namespace MyApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Usando classe abstrata. Permite criar collections para melhor proveito do polimorfismo
            List<Account> accounts = new List<Account>();

            accounts.Add(new SavingsAccount(1001, "Alex", 500.00, 0.01));
            accounts.Add(new BusinessAccount(1002, "Alex", 500.00, 400.00));
            accounts.Add(new SavingsAccount(1003, "Juliana", 500.00, 0.01));
            accounts.Add(new BusinessAccount(1004, "Juan", 500.00, 500.00));

            //Calcular a soma de todas as contas
            double sum = 0.0;
            foreach(Account acc in accounts)
            {
                sum += acc.Balance;
            }

            Console.WriteLine($"Total balance: {sum.ToString("F2", CultureInfo.InvariantCulture)}");

            foreach(Account acc in accounts)
            {
                acc.Withdraw(10.0);
            }

            foreach(Account acc in accounts)
            {
                Console.WriteLine("Updated balance for account "
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture)
                    );
            }

        }
    }
}