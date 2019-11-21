using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgSlideAulas.Heranca2
{
    public class Funcionario : Pessoa
    {
        public double Salario { get; set; }
        public Funcionario()
        {
            //segundo a ser executado
            Console.WriteLine("Eu sou a classe funcionario");
        }
        //demostração de contrutor com passagem de parametro no filho
        //public Funcionario(int idade) : base(idade)
        //{

        //}

    }
}
