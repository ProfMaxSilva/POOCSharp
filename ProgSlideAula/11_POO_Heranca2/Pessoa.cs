using System;

namespace ProgSlideAulas.Heranca2
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Pessoa()
        {
            //primeiro a ser executado
            Console.WriteLine("Eu sou a classe pessoa");
        }

        //demostração de contrutor com passagem de parametro no pai
        //apagar o contrutor vazio
        //public Pessoa(int idade)
        //{
        //    this.Idade = idade;
        //}
    }
}
