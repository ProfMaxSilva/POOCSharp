using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgSlideAulas.Sobrecarga
{
    public class Televisao
    {
        public int NumeroCanal { get; set; }
        public double Volume { get; set; }
        public bool Ligada { get; set; }

        public void ligar(int numeroCanal, double volume)
        {
            this.NumeroCanal = numeroCanal;
            this.Volume = volume;
            this.Ligada = true;
            List<MalaDireta> te = new List<MalaDireta>();
        }

        public void ligar(int numeroCanal)
        {
            this.ligar(numeroCanal, 30);
        }

        public void ligar()
        {
            this.ligar(200, 30);
        }

    }
}
