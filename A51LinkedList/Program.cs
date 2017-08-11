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
            //Imagine uma lista de frutas
            List<string> frutas = new List<string>()
            {
                "abacate", "banana", "caqui", "damasco", "figo"
            };

            Console.Clear();
            foreach (var f in frutas)
            {
                Console.WriteLine(f);
            }
            ///<image url="$(ProjectDir)\Slides\image1.png" scale=""/>
            //Adicionar um elemento ao final de uma lista é fácil

            //Porém inserir no meio da lista exige mais esforço computacional
            
            frutas.Insert(2, "caju");
            Console.Clear();
            foreach (var f in frutas)
            {
                Console.WriteLine(f);
            }
            ///<image url="$(ProjectDir)\Slides\image2.png" scale=""/>
            //porque os elementos têm que ser deslocados para darem
            //espaço ao novo elemento!

            //e se tivermos que remover esse elemento, os elementos
            //seguintes precisam ser deslocados de novo!

            Console.WriteLine();
            frutas.Remove("caju");
            foreach (var f in frutas)
            {
                Console.WriteLine(f);
            }

            //Quanto maior a lista, mais ineficiente é a inserção
            //e remoção de elementos no meio dela!

            //Que coleção é mais apropriada para inserção/remoção rápida?
            //Apresentando LISTA LIGADA (LINKED LIST):
            //- Elementos não precisam estar em sequência em memória
            //- Cada elemento sabe quem é o anterior e o próximo
            //- Cada elemento é um "nó" que contém um valor
            ///<image url="$(ProjectDir)\Slides\linked.png" scale=""/>

            //Como a ordem é mantida? Usando ponteiros
            ///<image url="$(ProjectDir)\Slides\linked2.png" scale=""/>
            //Instanciando uma nova lista ligada: dias da semana
            LinkedList<string> dias = new LinkedList<string>();
            
            //Adicionando um dia qualquer: "quarta"
            var d4 = dias.AddFirst("quarta");

            //"quarta" é o primeiro elemento da lista ligada
            ///<image url="$(ProjectDir)\Slides\image3.png" scale=""/>
            //cada elemento é um nó: LinkedListNode<T>
            //System.Collections.Generic.LinkedListNode`1[System.String]
            Console.WriteLine(d4.GetType());

            //Mas e o valor "quarta"? Está na propriedade d4.Value
            Console.WriteLine("d4.Value: " + d4.Value);

            var d2 = dias.AddBefore(d4, "segunda");
            ///<image url="$(ProjectDir)\Slides\image4.png" scale=""/>
            var d3 = dias.AddAfter(d2, "terça");
            ///<image url="$(ProjectDir)\Slides\image5.png" scale=""/>
            var d6 = dias.AddAfter(d4, "sexta");
            ///<image url="$(ProjectDir)\Slides\image6.png" scale=""/>
            var d7 = dias.AddAfter(d6, "sábado");
            ///<image url="$(ProjectDir)\Slides\image7.png" scale=""/>
            var d5 = dias.AddBefore(d6, "quinta");
            ///<image url="$(ProjectDir)\Slides\image8.png" scale=""/>
            var d1 = dias.AddBefore(d2, "domingo");
            ///<image url="$(ProjectDir)\Slides\image9.png" scale=""/>

            foreach (var d in dias)
            {
                Console.WriteLine(d);
            }

            dias.Remove(d4);

            foreach (var d in dias)
            {
                Console.WriteLine(d);
            }
        }
    }

}
