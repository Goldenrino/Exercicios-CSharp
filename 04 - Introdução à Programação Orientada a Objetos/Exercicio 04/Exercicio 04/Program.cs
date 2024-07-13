using System;
using System.Globalization;

namespace Exercicio04 {
    internal class Program {
        static void Main(string[] args) {

            Funcionario f = new Funcionario();
            
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + f);

            Console.WriteLine();
            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + f);
        }
    }
}
