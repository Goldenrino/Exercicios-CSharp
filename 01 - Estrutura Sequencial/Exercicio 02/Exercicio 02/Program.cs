using System;
using System.Globalization;

namespace Exercicio02
{
    internal class Program {
        static void Main(string[] args) {

            double r, a;

            r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            a = Math.PI * Math.Pow(r, 2.0);

            Console.WriteLine("A = " + a.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}