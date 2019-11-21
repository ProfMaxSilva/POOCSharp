namespace ProgSlideAulas.Heranca2
{
    public class Quadrado : Figura
    {
        public double Lado { get; set; }
        //demonstrar que tem que usar pelo um construtor do pai
        //demonstrar que passando os dados para o contrutor do pai
        //demonstrar que quando o pai tem um contrutor vazio pode-se se usar ou não
        //palavra chave base ex: public Quadrado():base
        //public Quadrado()
        //{

        //}
        public Quadrado(int codigo) : base(codigo)
        {

        }

        //public quadrado(string nome):base(nome)
        //{

        //}
    }
}
