using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgSlideAulas.Heranca
{
    public class Gerente : Funcionario
    {
        public string Area { get; set; }
        private List<Funcionario> _funcionarios;
        public Gerente()
        {
            _funcionarios = new List<Funcionario>();
        }
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
