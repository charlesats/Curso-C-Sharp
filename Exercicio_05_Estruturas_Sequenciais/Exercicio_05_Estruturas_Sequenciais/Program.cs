using System;
using System.Globalization;

namespace Exercicio_05_Estruturas_Sequenciais
{
    class Program
    {
        static void Main(string[] args)
        {
            string peca1;
            string peca2;
            string[] vet1;
            string[] vet2;
            float numero_de_pecas1, valor_peca1, numero_de_pecas2, valor_peca2, SOMA;

            Console.WriteLine("Peça!");
            vet1 = Console.ReadLine().Split(' ');
            Console.WriteLine("Peça!");
            vet2 = Console.ReadLine().Split(' ');

            peca1 = vet1[0];
            numero_de_pecas1 = float.Parse(vet1[1]);
            valor_peca1 = float.Parse(vet1[2],CultureInfo.InvariantCulture);

            peca2 = vet2[0];
            numero_de_pecas2 = float.Parse(vet2[1]);
            valor_peca2 = float.Parse(vet2[2],CultureInfo.InvariantCulture);


            SOMA = numero_de_pecas1 * valor_peca1 + numero_de_pecas2 * valor_peca2;

            Console.WriteLine();
            Console.WriteLine($"VALOR A PAGAR: R${SOMA.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
