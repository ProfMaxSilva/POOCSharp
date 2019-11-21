using System;

namespace ProgSlideAulas.Heranca2
{
    public class Figura
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        //se tirar esse contrutor da erro nos filhos 
        //que nao tem a mesma assinatura no seu contrutor
        //public Figura()
        //{

        //}
        public Figura(int codigo)
        {
            this.Codigo = codigo;
        }
        /* se acrescentar um novo contrutor na classe figura noa da erro nos filho
         caso o mesmo implememe pelo ao menos um metodo do pai*/
        public Figura(String nome)
        {
            this.Nome = nome;
        }
        //aumento de escopo de contrutor
        public Figura(int codigo, String nome)
        {
            this.Codigo = codigo;
            this.Nome = nome;
        }
    }
}
