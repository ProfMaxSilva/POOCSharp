using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgSlideAulas.Composicao
{
    public class Gato
    {
        //public Cabeca cabeca { get; set; }
        //public Rabo rabo { get; set; }
        //public Pata pata { get; set; }


        private Cabeca _cabeca = new Cabeca();
        private Rabo _rabo = new Rabo();
        private Pata[] _patas = new Pata[4] { new Pata(), new Pata(), new Pata(), new Pata() };

        // todas as partes devem ser instaciadas assim que declaradas, isso garanti que as PARTES só
        //vao existir enquanto as partes também existirem(isso pode ser feito no construtor
        //public Gato()
        //{
        //    _cabeca = new Cabeca();
        //    _rabo = new Rabo();
        //    _patas = new Pata[4] { new Pata(), new Pata(), new Pata(), new Pata() };
        //}
        // fora da classe Gato não é possivél manipular os Gets e Sets, para garantir a morte da partes quando o gato morrer
        //outra caracteristica é que uma PARTE só pertence a um TODO , desse modo não é possivel emprestar partes do todo para outro todo
        //as classes partes não possui nenhuma implementação especial
        public void Pular()
        {
            //preparacao para o pulo
            GetCabeca().Olhar();
            GetRabo().Mexer();

            foreach (Pata pata in GetPatas())
            {
                pata.Pular();
            }
        }


        //ALUNO: os metodos abaixo sao privadas para garantir que somente o todo tem acesso as partes, conforme previsto diagrama
        private Cabeca GetCabeca()
        {
            return this._cabeca;
        }

        private Rabo GetRabo()
        {
            return this._rabo;
        }

        private Pata[] GetPatas()
        {
            return this._patas;
        }


    }
}
