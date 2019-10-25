namespace ProgSlideAulas.Colecoes
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }

        public Cliente()
        {

        }
        public Cliente(int codigo)
        {
            this.Codigo = codigo;
        }
        public Cliente(int codigo, double saldo)
        {
            this.Codigo = codigo;
            this.Saldo = saldo;
        }

        public string ToString()
        {
            return string.Format("Codigo:{0} Nome{1}", Codigo, Nome);
        }

    }
}
