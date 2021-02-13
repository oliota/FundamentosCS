using System;
using System.Collections.Generic;
using System.Text;

namespace IntroducaoCS
{
    public class CalculadoraCientifica
    {
        int menu = 0;
         
        public delegate void MatematicaDelegate();
        MatematicaDelegate Somar,Subtrair,Dividir,Multiplicar,InformarNumeros;

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
            DefinirDelegados(); 
            while (menu != -1)
            {
                Menu();
            }
        }

        private void DefinirDelegados()
        {
            Matematica Matematica = new Matematica();
            Somar = new MatematicaDelegate(Matematica.Somar);
            Subtrair = new MatematicaDelegate(Matematica.Subtrair);
            Dividir = new MatematicaDelegate(Matematica.Dividir);
            Multiplicar = new MatematicaDelegate(Matematica.Multiplicar);
            InformarNumeros = new MatematicaDelegate(Matematica.InformarNumeros);
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
            string input = Console.ReadLine();

            Enum.TryParse<Operacoes>(input, out Operacoes operacao); 
            if (Enum.IsDefined(typeof(Operacoes), operacao))
            {
                Console.WriteLine($"Operação escolhida = {operacao}");
                menu = (int)operacao;
                if (menu != (int)Operacoes.Sair)
                {
                    InformarNumeros();
                }  
            }


            switch (operacao)
            {
                case Operacoes.Somar:
                    Somar();
                    break;
                case Operacoes.Subtrair:
                    Subtrair();
                    break;
                case Operacoes.Multiplicar:
                    Multiplicar();
                    break;
                case Operacoes.Dividir:
                    Dividir();
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
