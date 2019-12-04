using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgSlideAulas.InterfacesHerancaMultipla
{
    public abstract class JogadorFutebol : IAnimal, IEsportista
    {
        public object MyProperty { get; set; }
        public void Competir()
        {
            Console.WriteLine("Jogador Competindo");
        }

        public void Respirar()
        {
            Console.WriteLine("Jogador Respirando");
        }
    }
}
