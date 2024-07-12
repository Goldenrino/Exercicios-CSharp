using System;

namespace Exercicio08 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int i = 1; i <= n; i++) {
                fat = fat * i;
            }

            Console.WriteLine(fat);
        }
    }
}