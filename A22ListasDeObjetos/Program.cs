using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A22ListasDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //string aulaIntro = "Introdução às Coleções";
            //string aulaModelando = "Modelando a Classe Aula";
            //string aulaSets = "Trabalhando com Conjuntos";
            ///<image url='$(ProjectDir)\Slides\image01.png'/>
            var aulaIntro = new Aula("Introdução às Coleções", 15);
            var aulaModelando = new Aula("Modelando a Classe Aula", 16);
            var aulaSets = new Aula("Trabalhando com Conjuntos", 17);
            ///<image url='$(ProjectDir)\Slides\image02.png'/>
            //List<Aula> aulas = new List<Aula>();
            //aulas.Add(aulaIntro);
            //aulas.Add(aulaModelando);
            //aulas.Add(aulaSets);
            ///<image url='$(ProjectDir)\Slides\image03.png'/>
            List<Aula> aulas = new List<Aula>
            {
                aulaIntro, aulaModelando, aulaSets
            };

            ///<image url='$(ProjectDir)\Slides\image04.png'/>
            //aulas.Add("Conclusão");

            ///<image url='$(ProjectDir)\Slides\image05.png'/>
            Imprimir(aulas);
            ///<image url='$(ProjectDir)\Slides\image06.png'/>

            ///<image url='$(ProjectDir)\Slides\image07.png'/>
            aulas.Sort();
///<image url='$(ProjectDir)\Slides\image08.png'/>
            
///<image url='$(ProjectDir)\Slides\image09.png'/>
            Imprimir(aulas);

            ///<image url='$(ProjectDir)\Slides\image10.png'/>
            aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
            ///<image url='$(ProjectDir)\Slides\image11.png'/>
            Imprimir(aulas);
        }

        private static void Imprimir(List<Aula> aulas)
        {
            Console.Clear();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }

    internal class Aula : IComparable
    {
        private string titulo;
        private int tempo;

        public Aula(string titulo, int tempo)
        {
            this.titulo = titulo;
            this.tempo = tempo;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Tempo { get => tempo; set => tempo = value; }

        public int CompareTo(object obj)
        {
            var other = obj as Aula;
            return this.titulo.CompareTo(other.titulo);
        }

        public override string ToString()
        {
            return $"[titulo: {titulo} - duração: {tempo} minutos]";
        }
    }
}

















