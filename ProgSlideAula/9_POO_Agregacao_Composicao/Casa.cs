using System.Collections.Generic;

namespace ProgSlideAulas.Agregacao
{
    public class Casa
    {
        //private int NumeroCasa { get; set; }
        //public List<Janela> Janelas { get; set; }
        //public List<Porta> Portas { get; set; }
        //public Telhado Telhado { get; set; }

        private int _numeroCasa;
        private List<Janela> _janelas;
        private List<Porta> _portas;
        private Telhado _telhado;

        public Casa(int numeroCasa)
        {
            this._numeroCasa = numeroCasa;
            this._janelas = new List<Janela>();
            this._portas = new List<Porta>();
        }

        public void SetNumeroCasa(int numeroCasa)
        {
            this._numeroCasa = numeroCasa;
        }

        public int GetNumeroCasa()
        {
            return this._numeroCasa;
        }

        public void SetJanelas(List<Janela> janelas)
        {
            this._janelas.AddRange(janelas);
        }

        public void SetJanelas(Janela janela)
        {
            this._janelas.Add(janela);
        }

        public List<Janela> GetJanelas()
        {
            return this._janelas;
        }

        public void SetPortas(List<Porta> portas)
        {
            this._portas.AddRange(portas);//avisar o aluno para ter atenção
        }

        public void SetPortas(Porta porta)
        {
            this._portas.Add(porta);
        }

        public List<Porta> GetPortas()
        {
            return this._portas;
        }

        public void SetTelhado(Telhado telhado)
        {
            this._telhado = telhado;
        }

        public Telhado GetTelhado()
        {
            return this._telhado;
        }
    }
}
