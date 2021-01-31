using System;
using System.Collections.Generic;
using System.Text;

namespace IntroducaoCS
{
    class Calculadora
    {
        int menu = 0;
        private enum Operacoes : Int32
        {
            Somar = 1,
            Subtrair = 2,
            Multiplicar = 3,
            Dividir = 4,
            Sair = -1
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
                if (menu != (int)Operacoes.Sair)
                    InformarNumeros(out numero1, out numero2);
            }


            switch (operacao)
            {
                case Operacoes.Somar:
                    Somar(numero1, numero2);
                    break;
                case Operacoes.Subtrair:
                    Subtrair(numero1, numero2);
                    break;
                case Operacoes.Multiplicar:
                    Multiplicar(numero1, numero2);
                    break;
                case Operacoes.Dividir:
                    Dividir(numero1, numero2);
                    break;
                case Operacoes.Sair:
                    Console.WriteLine("Calculadora finalizada");
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }
            Utils.Pausar();
        }

        private void InformarNumeros(out double numero1, out double numero2)
        {
            Console.WriteLine("Informe o primeiro numero");
            numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero");
            numero2 = double.Parse(Console.ReadLine());
        }

        private void ListarOperacoes()
        {
            Console.WriteLine("Operações disponíveis");
            foreach (var elemento in Enum.GetValues(typeof(Operacoes)))
            {
                Console.WriteLine($"\t- {elemento } ou { (int)elemento }");
            }
        }

        private static void Somar(double numero1, double numero2)
        {
            Console.WriteLine($" Somar {numero1} + {numero2} =  {numero1 + numero2}");
        }

        private static void Subtrair(double numero1, double numero2)
        {
            Console.WriteLine($" Subtrair {numero1} - {numero2} =  {numero1 - numero2}");
        }

        private static void Multiplicar(double numero1, double numero2)
        {
            Console.WriteLine($" Multiplicar {numero1} * {numero2} =  {numero1 * numero2}");
        }

        private static void Dividir(double numero1, double numero2)
        {
            Console.WriteLine($" Dividir {numero1} / {numero2} =  {numero1 / numero2}");
        }
    }
}
