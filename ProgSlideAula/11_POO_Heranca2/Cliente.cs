using System;

namespace ProgSlideAulas.Heranca2
{
    public class Cliente : Pessoa
    {
        public double Saldo { get; set; }
        //a unica forma de contruir um cliente é contruindo uma pessoa
        public Cliente()
        {
            //segundo a ser executado
            Console.WriteLine("Eu sou a classe cliente");
        }
        //demostração de contrutor com passagem de parametro no filho
        //public Cliente(int idade):base(idade)
        //{

        //}
    }
}
