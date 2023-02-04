using System;

namespace Exercicio
{
    class ProjetoDoze
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor de linhas. Cada linha conterá o respectivo valor elevado ao quadrado e ao cubo.");
            int numLinhas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numLinhas; i++)
            {
                Console.Write("{0}: ", i);
                Console.Write($"{Math.Pow(i, 2)} ");
                Console.WriteLine(Math.Pow(i, 3));
            }
            Console.WriteLine("Fim!");

            Console.ReadKey();
        }
    }
}