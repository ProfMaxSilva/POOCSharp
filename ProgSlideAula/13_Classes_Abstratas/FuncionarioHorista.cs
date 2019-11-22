using System;

namespace ProgSlideAulas.ClassesAbstratas
{
    public class FuncionarioHorista : Funcionario
    {

        public double ValorHora { get; set; }
        public double HorasTrabalhadas { get; set; }
        public FuncionarioHorista():base(20)
        {

        }

        //caso nao tivesse o override nesta classe filha de uma classe abstrata daria o erro
        public override double ObterSalarioBruto()
        {
            return (ValorHora * HorasTrabalhadas) + base.ComplementoSalarial ;
        }

        //retorna o nome e o numero do registro e o salario sem complemento
        public override string ToString()
        {
            return string.Format("{0}\nSalario sem complemento{1}", base.ToString(), (ValorHora * HorasTrabalhadas));
        }

    }
}
