using System;

namespace IntroducaoCS
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomizarCor();
             
            ApresentacaoPessoal();

            UtilizarCalculadora();

            Utils.Pausar(true);

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

        private static void CustomizarCor()
        {
            if (Utils.ObterAprovacao("Gostaria de customizar as cores do console?"))
            {
                var Cores = new CoresConsole();
                Cores.ColorirConsole();
            }
            Console.Clear();
        }


    }
}
