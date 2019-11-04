using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgSlideAulas.Agregacao
{
   public class Porta
    {
        //public double Largura { get; set; }
        //public double Altura { get; set; }
        //public Casa Casa { get; set; }

        private double _largura;
        private double _altura;
        private Casa _casa;

        public void SetLargura(double Largura)
        {
            this._largura = Largura;
        }

        public double GetLargura()
        {
            return this._largura;
        }

        public void SetAltura(double altura)
        {
            this._altura = altura;
        }

        public double GetAltura()
        {
            return this._altura;
        }

        public void SetCasa(Casa casa)
        {
            this._casa = casa;
        }

        public Casa GetCasa()
        {
            return this._casa;
        }
    }
}
