using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IntroducaoCS
{
    class CoresConsole
    {
        public enum Cores : Int32
        { 
            Preto = ConsoleColor.Black, 
            AzulEscuro = ConsoleColor.DarkBlue, 
            CianoEscuro = ConsoleColor.DarkCyan, 
            VerdeEscuro = ConsoleColor.DarkGreen, 
            VermelhoEscuro = ConsoleColor.DarkRed, 
            MagentaEscuro = ConsoleColor.DarkMagenta, 
            AmareloEscuro = ConsoleColor.DarkYellow, 
            Grafite = ConsoleColor.DarkGray, 
            Azul = ConsoleColor.Blue, 
            Verde = ConsoleColor.Green, 
            Cyan = ConsoleColor.Cyan, 
            Vermelho = ConsoleColor.Red, 
            Magenta = ConsoleColor.Magenta, 
            Amarelo = ConsoleColor.Yellow, 
            Branco = ConsoleColor.White, 
            Cinza = ConsoleColor.Gray,  
        }

        public void ColorirConsole()
        {
            Console.Clear();
            ListarCores();
            Console.WriteLine("Selecione uma cor para o Background:");
            var Background = Console.ReadLine();
            

            Console.WriteLine("Selecione uma cor para o Texto:");
            var Texto = Console.ReadLine();

            if(ValidarDuplicidade(Background, Texto)){
                ColorirBackGround(Background);
                Console.Clear();
                ColorirTexto(Texto);
                Console.Clear();
            } 

            
        }

        private bool ValidarDuplicidade(string background, string texto)
        {
            if (background.Equals(texto))
            {
                Console.WriteLine("Se as cores de Background e Texto forem iguais não será possivel ler as informaçoes no console.");
                Utils.Pausar();
                ColorirConsole();
                return false;
            }
            return true;
        }

        private void ColorirBackGround(string escolha)
        {
            Cores cor;
            bool sucess = Enum.TryParse<Cores>(escolha, out cor);
            if (!sucess)
            {
                Console.WriteLine("A cor escolhida para o background não existe na paleta de cores");
                Utils.Pausar();
                return;
            }
            Console.BackgroundColor = (ConsoleColor)cor;

        }
        private void ColorirTexto(string escolha)
        {
            Cores cor;
            bool sucess = Enum.TryParse<Cores>(escolha, out cor);
            if (!sucess)
            {
                Console.WriteLine("A cor escolhida para o texto não existe na paleta de cores");
                Utils.Pausar();
                return;
            }
            Console.ForegroundColor = (ConsoleColor)cor; 

        }
        private void ListarCores()
        {
            Console.WriteLine("Opções de cores");
            foreach (var elemento in Enum.GetValues(typeof(Cores)))
            {

                Console.ForegroundColor = (ConsoleColor)elemento;
                if ((ConsoleColor)elemento == (ConsoleColor)Cores.Preto)
                    Console.BackgroundColor = (ConsoleColor)Cores.Branco;
                else
                    Console.BackgroundColor = (ConsoleColor)Cores.Preto;

                Console.WriteLine($"\t- { elemento } ou { (int) elemento }"); 
            }
        }
     


    }
}
