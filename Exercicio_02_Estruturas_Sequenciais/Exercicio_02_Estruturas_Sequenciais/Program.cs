using System;
using System.Globalization;

namespace Exercicio_02_Estruturas_Sequenciais
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, raio, pi = 3.14159;

            Console.WriteLine("Digite um raio!");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = Math.Pow(raio, 2) * pi;

            Console.Write("A = ");
            Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));            

        }
    }
}
