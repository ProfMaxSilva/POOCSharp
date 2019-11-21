using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgSlideAulas.Sobrecarga
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public double Saldo { get; set; }
        public string Nome { get; set; }

        public Cliente()
        {

        }
        public Cliente(int codigo)
        {
            Codigo = codigo;
        }
        public Cliente(int codigo, double saldo)
        {
            Saldo = saldo;
            Codigo = codigo;
        }
    }
}
