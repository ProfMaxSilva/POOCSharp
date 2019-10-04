using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgSlideAulas.Modificadores.ClasseLivro
{
    public class Livro
    {
        public string Titulo { private get; set; }
        public string Autor { get; set; }
        private double _valor;
       

        public DateTime DataNasc { get; set; }
        public int Idade
        {
            get
            {
                return DateTime.Now.Year - this.DataNasc.Year;
            }
        }

        public string Nome {           
            set
            {
                value = value.Trim();
            }
        }
        public double Valor
        {
            get
            {
                return this._valor;
            }
            set
            {
                this.Nome = "";
                this._valor = value;
            }
        }
        //private string titulo;
        //private string autor;
        //private double valor;

        //public string GetTitulo()
        //{
        //    return this.titulo;
        //}

        //public void SetTitulo(string titulo)
        //{
        //    this.titulo = titulo;
        //}

        //public string GetAutor()
        //{
        //    return this.autor;
        //}

        //public void SetAutor(string autor)
        //{
        //     this.autor = autor;
        //}

        //public double GetValor()
        //{
        //    return this.valor;
        //}

        //public void SetValor(double valor)
        //{
        //    this.valor = valor;
        //}

    }
}
