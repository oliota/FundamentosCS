using System;
using System.Security.Cryptography;
using static IntroducaoCS.CalculadoraCientifica;

namespace IntroducaoCS
{
    class Program
    {
        public delegate void CalculadoraDelegate();


        static void Main(string[] args)
        {

            //CustomizarCor();

            //ApresentacaoPessoal();

            //UtilizarCalculadora();

            //UtilizarCalculadoraCientifica();

            //CalculoDireto();

            ListaDeExercicios();



            Utils.Pausar();
        }
        private static void CustomizarCor()
        {
            if (Utils.ObterAprovacao("Gostaria de customizar as cores do console?"))
            {
                var Cores = new CoresConsole();
                Cores.ColorirConsole();
            }
            Console.Clear();
        }
        private static void ApresentacaoPessoal()
        {
            if (Utils.ObterAprovacao("Gostaria de se apresentar?"))
            {
                var Aluno = new Aluno();
                Aluno.DadosFixos();
                Aluno.MeApresentar();
            }
            Console.Clear();


        }
        private static void UtilizarCalculadora()
        {
            if (Utils.ObterAprovacao("Gostaria de utilizar a calculadora?"))
            {
                var Calculadora = new Calculadora();
                Calculadora.Iniciar();
            }
            Console.Clear();

        }
        private static void UtilizarCalculadoraCientifica()
        {
            if (Utils.ObterAprovacao("Gostaria de utilizar a calculadora cientifica?"))
            {
                var CalculadoraCientifica = new CalculadoraCientifica();
                CalculadoraCientifica.Iniciar();
            }

        }

        public delegate void MatematicaDelegate();

        private static void CalculoDireto()
        {
            if (Utils.ObterAprovacao("Gostaria de utilizar fazer uma soma agora?"))
            {
                Matematica Matematica = new Matematica();
                MatematicaDelegate Somar = new MatematicaDelegate(Matematica.Somar);
                MatematicaDelegate InformarNumeros = new MatematicaDelegate(Matematica.InformarNumeros);
                InformarNumeros();
                Somar();
            }

        }

        private static void ListaDeExercicios()
        {
            if (Utils.ObterAprovacao("Gostaria de ver o resultado da lista de exercicios?"))
            {
                var MenuDeExercicios = new MenuDeExercicios();
                MenuDeExercicios.Iniciar();
            }

        }
    }
}
