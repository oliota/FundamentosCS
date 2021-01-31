using System;
using System.Collections.Generic;
using System.Text;

namespace IntroducaoCS
{
    class Tipologia
    {

        public static void inteiro()
        {
            Console.WriteLine("\n INTEIRO");
            Console.WriteLine("------------------------");
            int idade = 31;
            var ano = 2021; 
            Console.WriteLine($"idade = {idade}");
            Console.WriteLine("ano = " + ano); 


            Console.WriteLine("Informe a sua idade:");
            var input = Console.ReadLine();
            int valorConvertido = Int32.Parse(input);

            Console.WriteLine($"Sua idade é :{valorConvertido}");
        }

        public static void numeroDecimal()
        { 
            Console.WriteLine("\n DECIMAL");
            Console.WriteLine("------------------------");
            float peso = 100.5f;
            double altura = 1.80;
            Console.WriteLine($"peso = {peso}");
            Console.WriteLine("altura = " + altura);


            Console.WriteLine("Informe o seu peso:");
            var input = Console.ReadLine();
            Double valorConvertido = Double.Parse(input);

            Console.WriteLine($"Seu peso é :{valorConvertido}");

        }

        public static void caracter()
        {
            Console.WriteLine("\n CARACTER");
            Console.WriteLine("------------------------");
            char letra = 'a';
            var inicial = 'r';
            Console.WriteLine($"letra = {letra}");
            Console.WriteLine("inicial = " + inicial);


            Console.WriteLine("Informe a primeira letra do seu nome:");
            var input = Console.ReadKey(); 
            char valorConvertido = input.KeyChar;

            Console.WriteLine($"\nA primeira letra do seu nome é:{valorConvertido}");

        }

        public static void texto()
        {
            Console.WriteLine("\n STRING");
            Console.WriteLine("------------------------");
            string nome = "Rubem Duarte Oliota";
            var curso = "Fundamentos c#";
            Console.WriteLine($"nome = {nome}");
            Console.WriteLine("curso = " + curso);


            Console.WriteLine("Informe seu nome completo:");
            var input = Console.ReadLine();
            Console.WriteLine($"Seu nome completo é:{input}");


        }


     

        
    }
}
