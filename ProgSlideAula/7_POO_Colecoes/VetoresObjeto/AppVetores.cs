using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgSlideAulas.Colecoes
{
    public class AppVetores
    {
        public static int Main(string[] args)
        {
            //declaração de uma variavel inteira normal
            int varInt = 0;
            ///declaração de uma variavel que podera guardar um objeto array de inteiros
            ///os colchetes [] indicam que é um tipo de array
            int[] array1Int;

            ///declaração de um variavel que guarda um objeto array de inteiros
            ///criação de um objeto arry de inteiros de 10 posições
            ///a variavel array quarda o objeto array criado
            int[] array2Int = new int[10];
            ///declaração de uma variavel que guarda um objeto array de inteiros
            ///a criação de um objeto array de inteiros de 5 posições
            ///inicializaçao do array com os valores 4,22,12,6,81
            ///a variavel array 3 guarda o objeto criado
            int[] array3Int = new int[] { 4, 22, 12, 6, 81 };
            /// manipulação de um array
            array1Int = new int[10];

            array1Int[0] = 22;
            array1Int[1] = 43;
            array1Int[2] = 45;
            array1Int[3] = 34;
       
            ///pecorrer um vetor e alimentando um vetor
            for (int i = 3; i < array1Int.Length; i++)
            {
                array1Int[i] = i * 2;
            }

            ///não foi criando cinco objetos e sim cinco espaços para 
            ///conter cinco objeto
            Cliente[] array1Clientes = new Cliente[5];

            Cliente sml = new Cliente();
            sml.Codigo = 1;
            sml.Nome = "Aluna";
            sml.Saldo = 10000000;

            array1Clientes[0] = sml;
            //duas forma de alterar os dados no primeiro cliente
            sml.Saldo = 10;
            array1Clientes[0].Saldo *= 100000;
            ///outra forma de fazer
            array1Clientes[1] = new Cliente();
            array1Clientes[1].Codigo = 2;
            array1Clientes[1].Nome = "aluno";
            array1Clientes[1].Saldo = 2000;

            /// aqui apaga os dados da posição 1
            //array1Clientes[1] = sml;



            Cliente aux;
            for (int i = 0; i < array1Clientes.Length; i++)
            {
                aux = new Cliente(i + 1);
                array1Clientes[i] = aux;
            }

            ///se quisermos percorre um arra

            Console.WriteLine("Teste");
            return 0;
        }
    }
}
