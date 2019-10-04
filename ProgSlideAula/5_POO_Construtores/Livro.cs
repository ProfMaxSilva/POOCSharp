using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgSlideAulas.Construtores
{
    public class Livro
    {
        private string titulo;
        private string autor;
        private double valor;
        //exemplificar a metodos Explicitos
        //public Livro( String titulo)
        //public Livro( String titulo, string autor)
        public Livro(string titulo, string autor)
        {
            SetTtitulo(titulo);
            SetAutor(autor);
        }
        public string GetTituto()
        {
            return titulo;
        }
        public void SetTtitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public string GetAutor()
        {
            return this.autor;
        }
        public void SetAutor(string autor)
        {
            this.autor = autor;
        }
        public double GetValor()
        {
            return this.valor;
        }
        public void SetValor(double valor)
        {
            this.valor = valor;
        }
    }
}
