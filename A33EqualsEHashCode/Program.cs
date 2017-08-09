using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A33EqualsEHashCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("Dominando as coleções do C#", "Marcelo Oliveira");

            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));

            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);

            csharpColecoes.Matricula(a1);
            csharpColecoes.Matricula(a2);
            csharpColecoes.Matricula(a3);

            Console.WriteLine("Todos os alunos matriculados: ");
            csharpColecoes.Alunos.ToList().ForEach(aluno => {
                Console.WriteLine(aluno);
            });

            ///Imprimir: "O aluno a3 está matriculado?"
            
            ///Criar um método EstaMatriculado
            
            ///Vamos instanciar uma aluna (Vanessa Tonini)
            
            ///e verificar se Tonini está matriculada
            
            ///Mas a1 == a Tonini?
            
            ///O que ocorreu? a1 é equals a Tonini?
            
            ///São diferentes! Precisamos então implementar Equals()

            ///Agora fazemos a1 Equals tonini


            ///importante: rapidez da busca depende do CÓDIGO DE DISPERSÃO!

            ///obtendo o código de dispersão


            ///comparando código de dispersão de a1 e tonini


            ///IMPORTANTE!!
            ///Dois objetos que são iguais possuem o mesmo hash code.
            ///PORÉM, o contrário não é verdadeiro: 
            ///Dois objetos com mesmo hash codes não são necessariamente iguais! 

            
        }
    }
}
