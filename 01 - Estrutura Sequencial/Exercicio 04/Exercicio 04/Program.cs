using System;
using System.Globalization;

namespace Exercicio04
{
    internal class Program {
        static void Main(string[] args) {

            int numero, horas;
            double valorHora, salario;

            numero = int.Parse(Console.ReadLine());
            horas  = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horas * valorHora;

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = " + salario.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}