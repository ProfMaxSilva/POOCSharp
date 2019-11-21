using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgSlideAulas.Heranca2
{
    public class Gerente : Funcionario
    {
        public string Area { get; set; }

        public Gerente()
        {
            //terceiro a ser executado
            Console.WriteLine("Eu sou a classe gerente");
        }
        //demostração de contrutor com passagem de parametro no filho do filho
        //public Gerente(int idade) : base(idade)
        //{

        //}
        private List<Funcionario> _funcionarios;
    
        public List<Funcionario> GetFuncionario()
        {
            return this._funcionarios;
        }
        public void SetFuncionarios(Funcionario funcionario)
        {
            this._funcionarios.Add(funcionario);
        }
    }
}
