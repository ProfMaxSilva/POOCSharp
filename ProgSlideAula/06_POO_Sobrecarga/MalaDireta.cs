using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgSlideAulas.Sobrecarga
{
    public class MalaDireta
    {
        public void Imprimir()
        {
            Console.WriteLine("Olá cliente");
        }   

        public void Imprimir(string nome)
        {
            Console.WriteLine("Olá cliente"+ nome+ "!");
        }

        public void Imprimir (string nome,  string saudacao)
        {
            Console.WriteLine("Caro(a)" + saudacao + " "+ nome + ".");
        }
    }
}
