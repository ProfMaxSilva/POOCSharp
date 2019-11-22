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
        //demonstração de contrutor com passagem de parametro no filho
        //Erro 1 P2-  Comentar o construtor vazio e mostrar que ainda dar erro
        //Erro 1 P3-  Descomentar o código abaixo e demosntrar que ainda dar erro
        //pois para construir uma pessoa é preciso  passar uma idade descomentar as linha 
        //public Cliente(int idade)
        //{

        //}
        //Erro 1 P5-  Descomentar o código abaixo com o base e demonstrar que somente passando a idade no 
        //contrutor do filho ainda dar erro, a unica forma de resolver é enviar a informação para o pai
        //pelo base, descomentar as linha abaixo e mosntra que não dar erro
        //EXplicar o pq não dar erro
        //public Cliente(int idade) : base(idade)
        //{

        //}
    }
}
