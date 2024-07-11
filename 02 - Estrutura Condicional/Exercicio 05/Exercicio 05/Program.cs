using System;
using System.Globalization;

namespace Exercicio05
{
    internal class Program {
        static void Main(string[] args) {
            
            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);
            
            double total;
            if (A == 1) {
                total = B * 4.00;
            }
            else if (A == 2) {
                total = B * 4.50;
            }
            else if (A == 3) {
                total = B * 5.00;
            }
            else if (A == 4) {
                total = B * 2.00;
            }
            else {
                total = B * 1.50;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}