using System;

namespace ProgSlideAulas.ClassesAbstratas
{
    //public class Funcionario
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public int NumeroRegistro { get; set; }
        public double ComplementoSalarial { get; set; }

        public Funcionario(int numeroRegisto)
        {
            this.NumeroRegistro = numeroRegisto;
        }
        //public virtual double ObterSalarioBruto()
        //{
        //    return 0;
        //}
        /*
         mostrar para os alunos que um metodo abstrato não tem corpo somente assinatura,
         se colocar um corpo  em um metodo abstrato dará erro
         pois deve ser codificado apenas nas classes derivadas. */
        public abstract double ObterSalarioBruto();

        //retorna o nome e o numero do registro
        public override string ToString()
        {
            return string.Format("Nome:{0}\nNumero do Registro:{1}\n", Nome, NumeroRegistro);
        }
    }
}
