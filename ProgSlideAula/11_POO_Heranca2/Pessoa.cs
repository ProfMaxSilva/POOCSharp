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

        //demonstração de contrutor com passagem de parametro no pai
        //Erro 1 P1 - apagar o contrutor vazio e monstrar que dar erro no cliente
        //Erro 2 P4 - Descomentar o contrutor vazio e comentar o outro e monstrar que dar erro no cliente
        //public Pessoa(int idade)
        //{
        //    this.Idade = idade;
        //}
    }
}
