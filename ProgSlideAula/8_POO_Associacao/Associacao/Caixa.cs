using ProgSlideAulas.Associacao.Associacao1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgSlideAulas.Associacao.Associacao1
{
    public class Caixa
    {
        public int Codigo { get; set; }
        public string nomeOperador { get; set; }
        /*cria um atributo do tipo cliente com o objetivo de estabelecer
         * a  possibilidade de um possivél relacionamento
         * note que ainda há não nenhuma ligação ou relacionamento com cliente  só a possibilidade 
        */
        //public Cliente Cliente { get; set; }
        private Cliente cliente;

        public Cliente GetCliente()
        {
            return this.cliente;
        }
        public void SetCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }
    }
}
