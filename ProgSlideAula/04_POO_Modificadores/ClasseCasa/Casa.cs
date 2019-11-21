using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgSlideAulas.Modificadores.ClasseCasa
{
   public class Casa
    {
        public string cor;
        public int numero;
        
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
            return numero;
        }

        public double CalcularGasto(int numeroAdultos, int numeroCriancas)
        {
            return (numeroAdultos * 180) + (numeroCriancas * 90);
        }

    }
}
