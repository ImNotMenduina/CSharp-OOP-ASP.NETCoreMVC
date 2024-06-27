﻿using Acc.Entities;
using System;


//Sobreposição : é a implementação de um método de uma superclasse na subclasse;

//Para que um método comum(não abstrato) possa ser sobrepostp, deve ser incluído nele o prefixo "virtual"

//Ao sobrescrever um método, devemos incluir nele o prefixo "override"

namespace MyApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount baac = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING

            Account acc1 = baac;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            //DOWNCASTING

            BusinessAccount acc4 = (BusinessAccount)acc2; //Deve-se fazer casting explicito, // O compilador não de sabe qual subtipo é o objeto mais genérico.
            acc4.Loan(400.00);
            //BusinessAccount acc5 = (BusinessAccount)acc3;
            //Em tempo de execução que o compilador reconhece que o downcasting está errado, pois acc3 é do tipo SavingsAccount
            Console.WriteLine(acc4);

            //Operador "is"
            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            else
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}