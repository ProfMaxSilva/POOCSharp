using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgSlideAulas.Heranca
{
    public class Funcionario : Pessoa
    {
        public double Salario { get; set; }
        public Gerente Gerente { get; set; }

    }
}
