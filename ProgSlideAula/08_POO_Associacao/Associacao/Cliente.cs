using System;

namespace ProgSlideAulas.Associacao.Associacao1
{
    /* 
     * o objeto cliente pode em algum momento usar o objeto caixa
     * o objeto caixa em algum momento pode ser relacionado com um cliente 
     * esse relaciomento pode ser feito e desfeito a qualquer momento 
     */
    public class Cliente
    {
        private String nome;
        private double saldo;
        /*cria um atributo do tipo caixa com o objetivo de estabelecer
         * a  possibilidade de um possivél relacionamento
         * note que ainda não há nenhuma ligação ou relacionamento com caixa  só a possibilidade 
         */
        private Caixa caixa;

        public Caixa GetCaixa()
        {
            return caixa;
        }
        public void SetCaixa(Caixa caixa)
        {
            this.caixa = caixa;
        }
        public string getNome()
        {
            return nome;
        }
        public void SetNome( string nome)
        {
            this.nome = nome;
        }

        public double getSaldo()
        {
            return saldo;
        }
        public void SetSaldo(double saldo)
        {
            this.saldo = saldo;
        }

    }
}
