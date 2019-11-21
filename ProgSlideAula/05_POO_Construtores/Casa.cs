using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgSlideAulas.Construtores
{
    public class Casa
    {

        public string Cor { get; set; }
        public int Numero { get; set; }

        //exemplificar a metodos Implicidos
        ////public Casa()
        public Casa()
        {
            //AbrirPorta();
            FecharPorta();
        }
        public void AbrirPorta()
        {
            Console.WriteLine("Porta Aberta");
        }

        public void FecharPorta()
        {
            Console.WriteLine("Porta Fechar");
        }

        public void boasvindas(string nome)
        {
            Console.WriteLine("Boas vindas " + nome);
        }

        public int getNumeroCasa()
        {
            return Numero;
        }

        public double CalcularGasto(int numeroAdultos, int numeroCriancas)
        {
            return (numeroAdultos * 180) + (numeroCriancas * 90);
        }
    }
}
