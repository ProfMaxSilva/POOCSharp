namespace ProgSlideAulas.ClassesAbstratas
{
    public class FuncionarioMensalista : Funcionario
    {
        public double ValorSalarioMinimo { get; set; }
        public double QuantSalarioMinimo { get; set; }

        public FuncionarioMensalista(int NumeroRegisto) : base(NumeroRegisto)
        {

        }
        //caso nao tivesse o override nesta classe filha de uma classe abstrata daria o erro
        public override double ObterSalarioBruto()
        {
            return (QuantSalarioMinimo * ValorSalarioMinimo) + base.ComplementoSalarial ;
        }
        //retorna o nome e o numero do registro e o salario sem complemento
        public override string ToString()
        {
            return string.Format("{0}\nSalario sem Complemento:{1}", base.ToString(), (QuantSalarioMinimo * ValorSalarioMinimo));
        }
    }
}
