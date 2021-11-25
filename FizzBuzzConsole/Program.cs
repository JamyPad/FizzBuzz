using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzLogic;

namespace FizzBuzzConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------- FIZZ BUZZ ----------------------------");
            Console.WriteLine("Escriba un valor: ");
            int val= Int32.Parse(Console.ReadLine());

            var FB = new FizzBuzzClass();
            Console.WriteLine("{0}",FB.PrintNums(val));
            Console.Read();


        }
    }
}
