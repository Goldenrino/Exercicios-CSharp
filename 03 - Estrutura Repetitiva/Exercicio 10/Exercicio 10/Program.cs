using System;

namespace Exercicio10 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {

                int primeiro = i;
                int segundo = (int)Math.Pow(i, 2);
                int terceiro = (int)Math.Pow(i, 3);
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            }
        }
    }
} 