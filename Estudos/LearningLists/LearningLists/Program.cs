using System;
// biblioteca para usar listas
using System.Collections.Generic;

namespace LearningLists {
    class Program {
        static void Main(string[] args) {

            /* declaração e instanciação 
             de uma lista do tipo string */
            List<string> list = new List<string>();

            /* o comando Add adiciona os 
             elementos ao final de nossa lista */
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            /*o comando Insert adiociona os
             elementos na lista e nos permite
            escolher a posição que os mesmos
            serão inseridos */
            list.Insert(2, "Marco");

            /* o laço abaixo imprime os nomes
             que foram adicionados e inseridos */
            foreach (string nome in list) {
                Console.WriteLine(nome);
            }

            Console.WriteLine();

            /* o comando abaixo mostra o
             tamanho que a lista possui */
            Console.WriteLine("List count: " + list.Count + " elements");
            Console.WriteLine();

            /* a expressão lambda abaixo diz que
             vai mostrar o nome da primeira pessoa
            da lista cuja a primeira letra de seu
            nome seja 'A' */
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A' of the list is: " + s1);
            Console.WriteLine();

            /* faz o mesmo que o find, porém este
             encontra o elemento da última posição
            que segue o requisito da expressão abaixo */
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A' of the list is: " + s2);
            Console.WriteLine();
            
            /* o comando abaixo encontra a primeira
             posição do elemento que segue o predicado 
            informado abaixo */
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position starting with 'A' is: " + pos1);
            Console.WriteLine();

            /* o comando abaixo encontra a última
             posição do elemento que segue o predicado
            informado abaixo */
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position starting with 'A' is: " + pos2);
            Console.WriteLine();

            /* declaração de uma nova lista que recebe
             a lista anterior e uma condição que busca
            todos os elementos que satisfazem o predicado
            listado dentro do comando FindAll */
            List<string> list2 = list.FindAll(x => x.Length == 5);
            
            /* laço de repetição que mostra cada nome
             contido dentro da list2, com base no predicado
            listado acima */
            foreach (string nome in list2) {
                Console.WriteLine(nome);
            }

            Console.WriteLine();

            /* o comando abaixo remove um elemento da lista.
            * DETALHE *, somente irá remover se o
            elemento existir dentro da lista */
            list.Remove("Alex");

            /* o comando abaixo remove um elemento da lista
             a partir de sua posição */
            list.RemoveAt(3);

            /* o comando abaixo remove um elemento da lista
             a partir de sua posição e até uma certa contagem.
            Ex.: Remove o elemento da posição 2, até o 4,
            como demonstrado na linha abaixo */
            list.RemoveRange(2, 2);

            foreach (string nome in list) {
                Console.WriteLine(nome);
            }

            /* o comando abaixo remove os elementos
             da lista que estão dentro do predicado
            escrito abaixo */
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine();

            foreach (string nome in list) {
                Console.WriteLine(nome);
            }
        }
    }
}
