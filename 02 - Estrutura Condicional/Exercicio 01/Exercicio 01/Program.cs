using System;

namespace Exercicio01
{
    internal class Program {
        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine());

            if (x < 0) {
                Console.WriteLine("NEGATIVO");
            }
            else {
                Console.WriteLine("NAO NEGATIVO");
            }
        }
    }
}