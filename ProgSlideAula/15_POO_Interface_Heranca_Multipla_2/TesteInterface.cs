using System;
using System.Collections.Generic;
using System.Text;

namespace ProgSlideAula._15_POO_Interface_Heranca_Multipla_2
{
    public class TesteInterface : ITeste
    {
        public string ListarId(int id)
        {
            return ("Listei por ai");
        }

        public void Metodo1()
        {
            throw new NotImplementedException();
        }

        public int Metodo2(int p1, int p2)
        {
            throw new NotImplementedException();
        }

        public int Metodo2(int p1, string p2)
        {
            throw new NotImplementedException();
        }
    }
}
