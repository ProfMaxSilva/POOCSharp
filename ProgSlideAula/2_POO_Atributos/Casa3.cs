using System;

namespace POO_Atributos
{
    public class Casa
    {
        public String cor;
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
