using EmployeePayment.Entities;
using System.Globalization;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");

                Console.Write("Outsourced (y/n)");
                char op = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (op == 'y' || op == 'Y')
                {
                    Console.Write("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else if (op == 'n' || op == 'N')
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
                else
                {
                    Console.WriteLine("Invalid Option");
                    break;
                }
                Console.WriteLine();
            }

            Console.WriteLine("PAYMENTS: ");
            foreach (Employee emp in list)
            {
                if (emp is OutsourcedEmployee)
                {
                    OutsourcedEmployee outEmp = (OutsourcedEmployee)emp;
                    Console.WriteLine($"{outEmp.Name} - $ {outEmp.payment().ToString("F2", CultureInfo.InvariantCulture)}");
                }
                else
                {
                    Console.WriteLine($"{emp.Name} - $ {emp.payment().ToString("F2", CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
}