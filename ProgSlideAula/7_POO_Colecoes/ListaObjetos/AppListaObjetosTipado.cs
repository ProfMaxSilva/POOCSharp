using System;
using System.Collections.Generic;

namespace ProgSlideAulas.Colecoes.ListaObjetos
{
    public class AppListaObjetosTipado
    {
        public void ExecutaExemplo()
        {
            List<Cliente> Clientes = new List<Cliente>();
            Cliente c1 = new Cliente() { Codigo = 1, Nome = "Max", Saldo = 20.0 }; // mostrar pro aluno como fazer passando todos os parametros de uma só vez
            Cliente c2 = new Cliente { Codigo = 2, Nome = "Max2", Saldo = 20.0 };
            Cliente c3 = new Cliente(03);

            Clientes.Add(c1);
            Clientes.Add(c2);
            Clientes.Add(c3);
            Clientes.Add(new Cliente(4));// mostrar pro aluno que dar pra passar instancia

            for (int i = 0; i < Clientes.Count; i++)
            {
                Cliente aux = (Cliente)Clientes[i];

                Console.WriteLine(aux.ToString());
            }
        }
    }
}
