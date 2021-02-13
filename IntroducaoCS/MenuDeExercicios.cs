using System;
using System.Collections.Generic;
using System.Text;

namespace IntroducaoCS
{
    public class MenuDeExercicios : Exercicios
    {
        int menu = 0;
        private enum Operacoes : Int32
        {
            Sair = -1,
            InformarDadosPessoais = 1,
            CapturarDadosPessoais = 2,
            NumeroPar = 3,
            ExibirApenasMultiplos = 4,
            Capturar3_Notas_InformarMedia = 10,
            Capturar10_Notas_Com_For_InformarMedia = 11,
            Capturar_N_Notas_Com_Do_Whille_List_InformarMedia = 12,
        }
        public void Iniciar()
        {
            while (menu != -1)
            {
                Menu();
            }
        }

        public void Menu()
        {
            Console.Clear();
            ListarOperacoes();
            Escolher();
        }

        private void Escolher()
        {
            Console.WriteLine("Informe uma operação:");
            double numero1 = 0;
            double numero2 = 0;
            string input = Console.ReadLine();

            Enum.TryParse<Operacoes>(input, out Operacoes operacao);


            if (Enum.IsDefined(typeof(Operacoes), operacao))
            {
                Console.WriteLine($"Operação escolhida = {operacao}");
                menu = (int)operacao;
                Console.WriteLine("========================================");
            }


            switch (operacao)
            {
                case Operacoes.InformarDadosPessoais:
                    InformarDadosPessoais();
                    break;
                case Operacoes.CapturarDadosPessoais:
                    CapturarDadosPessoais();
                    break;
                case Operacoes.NumeroPar:
                    int numero = 2;
                    if (NumeroPar(numero))
                        Console.WriteLine($"{numero} é par");
                    else
                        Console.WriteLine($"{numero} é impar");
                    break;
                case Operacoes.ExibirApenasMultiplos:
                    int multiplo = 5;
                    int limite = 100;
                    Console.WriteLine($" Quantidade: {ExibirApenasMultiplos(multiplo, limite)}");
                    break;
                case Operacoes.Capturar3_Notas_InformarMedia:
                    Capturar3_Notas_InformarMedia();
                    break;
                case Operacoes.Capturar10_Notas_Com_For_InformarMedia:
                    Capturar10_Notas_Com_For_InformarMedia();
                    break;
                case Operacoes.Capturar_N_Notas_Com_Do_Whille_List_InformarMedia:
                    Capturar_N_Notas_Com_Do_Whille_List_InformarMedia();
                    break;

                case Operacoes.Sair:
                    Console.WriteLine("Lista de exercicios finalizada");
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }
            Utils.Pausar();
        }

        private void ListarOperacoes()
        {
            Console.WriteLine("Operações disponíveis");
            foreach (var elemento in Enum.GetValues(typeof(Operacoes)))
            {
                Console.WriteLine($"\t- {elemento } ou { (int)elemento }");
            }
        }




    }
}
