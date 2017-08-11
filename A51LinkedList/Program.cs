using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A51LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Imagine uma lista de frutas

            ///Vamos imprimir essa lista

            ///image1

            ///Adicionar um elemento ao final de uma lista é rápido

            ///Porém inserir no meio da lista exige mais esforço computacional

            ///image2

            ///porque os elementos têm que ser deslocados para darem
            ///espaço ao novo elemento!
            ///E se tivermos que remover esse elemento, os elementos
            ///seguintes precisam ser deslocados de novo!

            ///Quanto maior a lista, mais ineficiente é a inserção
            ///e remoção de elementos no meio dela!
            ///Que coleção é apropriada para inserção/remoção rápida?

            ///Apresentando LISTA LIGADA (LINKED LIST):
            ///- Elementos não precisam estar em sequência em memória
            ///- Cada elemento sabe quem é o anterior e o próximo
            ///- Cada elemento é um "nó" que contém um valor

            ///linked

            ///Como a ordem é mantida? Usando ponteiros
            ///linked2

            ///Instanciando uma nova lista ligada: dias da semana

            ///Adicionando um dia qualquer: "quarta"
            
            ///"quarta" é o primeiro elemento da lista ligada
            ///image3

            ///cada elemento é um nó: LinkedListNode<T>
            ///System.Collections.Generic.LinkedListNode`1[System.String]

            ///Mas e o valor "quarta"? Está na propriedade d4.Value

            ///E para adicionar mais itens? LinkedList não possui Add!
            ///Podemos adicionar de 4 formas:
            ///1. Como primeiró nó
            ///2. Como último nó
            ///3. Antes de um nó conhecido
            ///4. Depois de um nó conhecido

            ///Vamos adicionar segunda, antes de quarta:

            ///image4

            ///Agora d2 e d4 estão ligados!
            ///- d2.Next é igual a d4
            ///- d4.Previous é igual a d2
            ///Continuando com nossa lista ligada, 
            ///vamos adicionar terça depois de segunda

            ///image5

            ///Perceba que os "ponteiros", ou referências
            ///de d2 e d4 foram redirecionados para d3!!
            ///Vamos adicionar sexta depois de quarta

            ///image6

            ///sábado depois de sexta

            ///image7

            ///quinta antes de sexta

            ///image8

            ///domingo antes de segunda

            ///image9
            
            ///Agora vamos imprimir a lista ligada

            ///LinkedList NÃO DÁ suporte ao acesso de índice: dias[0]
            ///por isso podemos fazer um laço foreach mas não um for!
                        
            ///Para removermos um elemento, podemos tanto
            ///remover pelo valor quanto pela 
            ///referência do LinkedListNode
            ///dias.Remove("quarta") ou dias.Remove(d4);
            ///dias.Remove("quarta");
        }
    }

}
