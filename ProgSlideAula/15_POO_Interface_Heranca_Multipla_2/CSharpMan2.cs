using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgSlideAulas.InterfacesHerancaMultipla
{
    // não precisa implemenmtar a interface animal por causa da herença de interfaces
    public class CSharpMan2 : IProgramador2
    {
        public void Respirar()
        {
            Console.WriteLine("CSharpMen Respirando");
        }
        public void Programar()
        {
            Console.WriteLine("Programando em C#");
        }
    }
}
