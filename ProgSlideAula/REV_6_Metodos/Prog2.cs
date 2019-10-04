using System;

namespace ProgSlideAulas.metodos
{
    public class Prog2
    {
        //public static int Main(string[] args)
        //{
        //    double num1, num2, menor;

        //    Console.WriteLine("Digite o valor do numero 1");
        //    num1 = double.Parse(Console.ReadLine());

        //    Console.WriteLine("Digite o valor do numero 2");
        //    num2 = double.Parse(Console.ReadLine());

        //    menor = MenorValor(num1, num2);

        //    Console.WriteLine("O menor numero é: {0}", menor);
        //    return 0;
        //}

        private static double MenorValor(double num1, double num2)
        {
            if (num1 < num2)
                return num1;
            else
                return num2;
        }
    }
}