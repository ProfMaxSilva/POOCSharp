using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgSlideAulas.InterfacesHerancaMultipla
{
    // não precisa implemenmtar a interface animal por causa da heranças de interfaces
    public class JogadorFutebol2 : IEsportista2
    {
        public void Competir()
        {
            throw new NotImplementedException();
        }

        public void Respirar()
        {
            throw new NotImplementedException();
        }
    }
}
