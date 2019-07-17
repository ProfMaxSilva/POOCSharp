using System;
using System.Collections.Generic;
using System.Text;

namespace ProgSlideAula
{
    class Prog2
    {
        static int Main(string[] args)
        {
            //ExecutarExercicio1();
            ExecutarExercicio2();

            return 0;
        }
        public static void ExecutarExercicio1()
        {
            //Entre com seu nome e sobrenome, exiba os dados de entrada.
            Console.WriteLine("Informe o nome");
            string nome = Console.ReadLine();
            //
            Console.WriteLine("Informe o Sobrenome");
            string sobrenome = Console.ReadLine();

            Console.WriteLine("O nome é {0} e o Sobrenome é {1}", nome, sobrenome);
            //Evolua o exercício anterior e entre com seu nome, sua idade, exiba os dados de entrada
        }
        public static void ExecutarExercicio2()
        {
            //Evolua o exercício anterior e entre com seu nome, sua idade, exiba os dados de entrada
            Console.WriteLine("Informe o nome");
            string nome = Console.ReadLine();
            //
            Console.WriteLine("Informe o Sobrenome");
            string sobrenome = Console.ReadLine();
            //
            Console.WriteLine("Informe a idade");
            int idade = int.Parse(Console.ReadLine());
            //
            Console.WriteLine("O nome é {0} e o sobrenome é {1}, já a idade é {2}", nome, sobrenome, idade);
        }
    }
}
