using System;

namespace Exercicio04
{
    internal class Program {
        static void Main(string[] args) {
            
            string[] horas = Console.ReadLine().Split(' ');
            int A = int.Parse(horas[0]);
            int B = int.Parse(horas[1]);

            if (A < B) {
                Console.WriteLine("O JOGO DUROU " + (B - A) + " HORAS");
            }
            else {
                Console.WriteLine("O JOGO DUROU " + (24 - (A - B)) + " HORAS");
            }

        }
    }
}