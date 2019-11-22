using System;

namespace ProgSlideAulas.Subreescrita
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int NumeroRegistro { get; set; }
        public double ComplementoSalarial { get; set; }

        public Funcionario(int numeroRegisto)
        {
            this.NumeroRegistro = numeroRegisto;
        }

        public virtual double ObterSalarioBruto()
        {
            return 0;
        }
        //retorna o nome e o numero do registro
        public override string ToString()
        {
            return string.Format("Nome:{0}\nNumero do Registro:{1}\n", Nome, NumeroRegistro);
        }
    }
}
