using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IntroducaoCS
{
    class Apresentacao
    {
        public static void Start()
        {
            Apresentar();

            Proximo();

            Aulas();

            Proximo();

            PreRequisitos();

            Proximo();

            Assuntos();

            Proximo();

            ApresentacaoAluno();

            Proximo();

            IntroducaoDotNet();

            Proximo();

            AtividadesDeHoje();
        }

        private static void Apresentar()
        {
            string nome = "Rubem Oliota";
            Console.WriteLine($"Olá meu nome é {nome}");

            string formacao = "Sistemas de informação";
            Console.WriteLine($"Sou formado em {formacao} ");

            int idade = 31;
            Console.WriteLine($"Tenho {idade} anos");


            string trabalho = "Benner";
            string cargo = "Analista de sistemas";
            int tempoTrabalho = 2;
            Console.WriteLine($"Atualmente trabalho na {trabalho} no cargo {cargo} há {tempoTrabalho} anos ");


            ArrayList tecnologias = new ArrayList();

            tecnologias.Add("VB - Visual Basic");
            tecnologias.Add("C");
            tecnologias.Add("C#");
            tecnologias.Add("Java(Desktop e Web)");
            tecnologias.Add("Java(Android)");
            tecnologias.Add("Javascript");
            tecnologias.Add("Python");
            tecnologias.Add("Delphi");
            tecnologias.Add("Banco de dados (Sql server, Oracle, Firebase, Postgres e sqlLite)");
            tecnologias.Add("Html");
            tecnologias.Add("Css");

            Console.WriteLine($"\nTecnologias que aprendi durante minha carreira:");

            for (int i = 0; i < tecnologias.Count; i++)
            {
                Console.WriteLine($"\t{tecnologias[i]}");
            }
        }
        private static void Aulas()
        {
            string curso = "C# fundamentos";
            bool primeiraAula = true;
            if (primeiraAula)
            {
                Console.WriteLine($"Hoje é a primeira aula do curso {curso}");
            }

            ArrayList aulas = new ArrayList();
            aulas.Add("24/01/2021");
            aulas.Add("31/01/2021");
            aulas.Add("07/02/2021");
            aulas.Add("14/02/2021");
            aulas.Add("21/02/2021");
            aulas.Add("28/02/2021");

            Console.WriteLine($"\nTeremos {aulas.Count} aulas nas datas:");

            for (int i = 0; i < aulas.Count; i++)
            {
                Console.WriteLine($"\tAula {i + 1} - {aulas[i]}  {(i == 0 ? " (hoje)" : "")}");

            }
        }

        private static void Proximo()
        {

            Console.WriteLine($"\nAlguma pergunta? Ou pressione ENTER para continuar...");
            Console.ReadLine();
        }


        private static void PreRequisitos()
        {
            ArrayList pre_requisitos = new ArrayList();
            pre_requisitos.Add("Lógica");
            pre_requisitos.Add("Algoritmos");
            pre_requisitos.Add("Banco de Dados");
            pre_requisitos.Add("SQL e Orientação a Objetos ou possuir conhecimentos equivalentes");

            Console.WriteLine($"\nPara esse curso temos como pré-requisitos:");

            for (int i = 0; i < pre_requisitos.Count; i++)
            {
                Console.WriteLine($"\t{pre_requisitos[i]}");
            }
        }
        private static void Assuntos()
        {
            ArrayList assuntos = new ArrayList();
            assuntos.Add("Introdução ao .NET Framework");
            assuntos.Add("Trabalhando com I / O");
            assuntos.Add("Tipagem, operadores e sobrecargas");
            assuntos.Add("Estruturas de controle");
            assuntos.Add("Sobrecarga de operadores e Conversões implícitas e explícitas");
            assuntos.Add("Métodos, parâmetros e escopo");
            assuntos.Add("Encapsulamento, Herança e Polimorfismo");
            assuntos.Add("Interfaces, Structs e Enumeradores");
            assuntos.Add("Gerenciamento de Memória e Garbage Collection");
            assuntos.Add("Listas Genéricas e Vetores");
            assuntos.Add("Propriedades e Indexadores");
            assuntos.Add("Delegates, Eventos e Lambda Expressions");
            assuntos.Add("Namespaces e Assemblies");
            assuntos.Add("Reflection e DataAnnotations");
            assuntos.Add("Debug e Instrumentação");
            assuntos.Add("Design Patterns");
            assuntos.Add("Banco de Dados -ADO.NET e EF -ORM.");
            assuntos.Add("Criação de Protótipo de Software Comercial(cadastros/ relatório)");
            assuntos.Add("Introdução a tecnologia ASP.NET CORE");

            Console.WriteLine($"\nO que aprenderemos nesse curso:");

            for (int i = 0; i < assuntos.Count; i++)
            {
                Console.WriteLine($"\t{assuntos[i]}");
            }
        }

        private static void ApresentacaoAluno()
        {

            Console.WriteLine($"\nQuero conhecer vocês");
            Console.ReadLine();
        }

        private static void IntroducaoDotNet()
        {

            Console.WriteLine($"\nIntrodução ao .Net FrameWork");
            Console.ReadLine();
        }

        private static void AtividadesDeHoje()
        {
            Console.WriteLine($"Vamos por a mão na massa?");
            Console.ReadLine();

            Console.WriteLine($"\nAtividades de hoje");
            Console.WriteLine($"Criar primeiro programa no Visual studio");
            Proximo();
            Console.WriteLine($"Tipagem(variaveis) (int)");
            Proximo();
            Console.WriteLine($"Tipagem(variaveis) (double)");
            Proximo();
            Console.WriteLine($"Tipagem(variaveis) (char)");
            Proximo();
            Console.WriteLine($"Tipagem(variaveis) (string)");
            Proximo();
            Console.WriteLine($"Estruturas de controle (if, if-else )");
            Proximo();
            Console.WriteLine($"Estruturas de controle (switch )");
            Proximo();
            Console.WriteLine($"Estruturas de controle (for )");
            Proximo();
            Console.WriteLine($"Estruturas de controle (while, do-while )");
            Proximo();
            Console.WriteLine($"Metodos (parametros, sobrecarga)");
            Proximo();
            Console.WriteLine($"Vamos por a mão na massa?");
            Proximo();
        }

        private static void metodo1()
        {
            #region HelloWorld
            //cw
            //Console.WriteLine("Hello World!");
            #endregion

            #region snippet
            //cr
            //var input = Console.ReadLine();
            #endregion

            #region atalhos
            //Ctrl K + Ctrl D = Organizar codigo (se houver seleção de texto só sera organizada a seleção)
            //Ctrl K + Ctrl C = Comentar codigo (se houver seleção de texto só sera comentada a seleção)
            //Ctrl K + Ctrl U = Descomentar codigo (se houver seleção de texto só sera descomentada a seleção)
            //Ctrl R + Ctrl G = remove os using desnecessários (os usings ficam nas primeiras linhas do arquivo.cs)
            //f5 = executa o projeto
            #endregion


        }
    }


}
