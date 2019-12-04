using System;
using System.Collections.Generic;
using System.Text;

namespace ProgSlideAula._15_POO_Interface_Heranca_Multipla_2
{
    public interface ITeste
    {
        void Metodo1();
        int Metodo2(int p1, int p2);
        int Metodo2(int p1, string p2);
        String ListarId(int id);
    }
}
