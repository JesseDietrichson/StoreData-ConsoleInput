using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");

            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name}");


            Console.WriteLine("Enter a number");

            int number = int.Parse(Console.ReadLine());

            double decimalNumber = double.Parse(Console.ReadLine());

        }
    }
}
