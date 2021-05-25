using System;
using System.Globalization;

namespace Exercicio_06_Estruturas_Sequenciais
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, TRIANGULO, CIRCULO, TRAPEZIO, QUADRADO, RETANGULO, pi = 3.14159;
            string[] vet;

            Console.WriteLine("Digite os valores de entrada!");
            vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            TRIANGULO = (A * C / 2);
            CIRCULO = Math.Pow(C, 2) * pi;
            TRAPEZIO = ((A + B) * C) / 2;
            QUADRADO = Math.Pow(B, 2);
            RETANGULO = A * B;

            Console.WriteLine();
            Console.WriteLine($"TRINGULO: {TRIANGULO.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {CIRCULO.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {TRAPEZIO.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {QUADRADO.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {RETANGULO.ToString("F3", CultureInfo.InvariantCulture)}");

                        
        }
    }
}
