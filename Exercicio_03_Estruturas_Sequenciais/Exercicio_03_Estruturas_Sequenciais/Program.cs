using System;

namespace Exercicio_03_Estruturas_Sequenciais
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, DIFERENCA;

            Console.WriteLine("Digite os valores!");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            DIFERENCA = (A * B - C * D);

            Console.WriteLine($"DIFERENCA = {DIFERENCA}");
        }
    }
}
