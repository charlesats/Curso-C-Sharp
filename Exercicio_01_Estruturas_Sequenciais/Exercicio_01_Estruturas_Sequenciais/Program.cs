using System;

namespace Exercicio_01_Estruturas_Sequenciais
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Digite um número!");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número!");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"A soma é: {n1+n2}");
            
        }
    }
}
