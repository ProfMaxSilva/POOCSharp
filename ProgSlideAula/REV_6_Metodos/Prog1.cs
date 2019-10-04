using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgSlideAulas.metodos
{
    public class Prog01
    {
        public void imprimir()
        {
            Console.WriteLine("Metodo Imprimir");
        }

        public void imprimirNome(String nome)
        {
            Console.WriteLine("Metodo Imprimir nome: {0}", nome);
        }

        public void imprimirInteiro(int inteiro)
        {
            Console.WriteLine("Metodo Imprimir Inteiro: {0}", inteiro);
        }

        public void imprimirSoma(int valor1, int valor2)
        {
            int soma;
            soma = valor1 + valor2;
            Console.WriteLine("A soma é: {0}", soma);
        }

        public static int Multiplicar(int valor1, int valor2)
        {
            int multiplicação;
            multiplicação = valor1 + valor2;
            return multiplicação;
        }

        //public static int Main(string[] args)
        //{
        //    Metodo1();
        //    return 0;
        //}
        public static void Metodo1()
        {
            Metodo2();
        }
        public static void Metodo2()
        {
            Console.WriteLine("Executando o Metodo 2");
        }
    }
}
