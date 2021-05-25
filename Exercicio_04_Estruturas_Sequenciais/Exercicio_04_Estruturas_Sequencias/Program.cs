using System;
using System.Globalization;

namespace Exercicio_04_Estruturas_Sequencias
{
    class Program
    {
        static void Main(string[] args)
        {
            string num;
            float salario;
            float horas;

            Console.WriteLine("Digite o número do funcionário!");
            num = Console.ReadLine();
            Console.WriteLine("Digite o números de horas!");
            horas = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor por horas trabalhadas!");
            salario = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"NUMBER = {num}");
            Console.WriteLine($"SALARY = U${(horas * salario).ToString("F2",CultureInfo.InvariantCulture)}");

        }
    }
}
