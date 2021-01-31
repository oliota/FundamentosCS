using System;
using System.Collections.Generic;
using System.Text;

namespace IntroducaoCS
{
    class Operadores
    {  

        public static void soma()
        {
            Console.WriteLine("\n SOMA +");
            Console.WriteLine("------------------------");
            double produto = 30.5;
            double acrescimo = .5;
            Console.WriteLine($"o produto custa  {produto} e o acrescimo será de {acrescimo}");

            double soma = produto + acrescimo;
            Console.WriteLine($"soma = {soma}");
            Console.WriteLine($"soma = {produto + acrescimo}");

            Console.WriteLine("Informe sua idade:");
            var idade = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Em 10 anos você terá {idade + 10} anos");  
        }

        public static void subtracao()
        {
            Console.WriteLine("\n SUBTRAÇÃO - ");
            Console.WriteLine("------------------------");
            double produto = 100;
            double desconto = 30.5;
            Console.WriteLine($"o produto custa  {produto} e o desconto será de {desconto}");

            double subtracao = produto - desconto;
            Console.WriteLine($"subtracao = {subtracao}");
            Console.WriteLine($"subtracao = {produto - desconto}");

            Console.WriteLine("Informe seu ano de nascimento:");
            var ano = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Sua idade é :{2021 - ano}"); 
        }

        public static void divisao()
        {
            Console.WriteLine("\n DIVISÃO / ");
            Console.WriteLine("------------------------");
            double valor1 = 10;
            double valor2 = 2;
            Console.WriteLine($"Vamos dividor {valor1} por {valor2}");

            double divisao = valor1 / valor2;
            Console.WriteLine($"divisao = {divisao}");
            Console.WriteLine($"divisao = {valor1 / valor2}");


            double pizza = 80;
            Console.WriteLine($"O valor da pizza é: R$ {pizza}");
            Console.WriteLine("Vai dividir o valor com quantos amigos?");
            var amigos = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Cada um deve pagar +/- :{pizza / amigos}");  
        }

        public static void multiplicacao()
        {
            Console.WriteLine("\n MULTIPLICAÇÃO * ");
            Console.WriteLine("------------------------");
            double preco = 50.5;
            int quantidade = 10;
            Console.WriteLine($"Vamos multiplicar {preco} por {quantidade}");

            double multiplicacao = preco * quantidade;
            Console.WriteLine($"multiplicacao = {multiplicacao}");
            Console.WriteLine($"multiplicacao = { preco * quantidade}");


            double cerveja = 4.5;
            Console.WriteLine($"O valor da cerveja é: R$ {cerveja}");
            Console.WriteLine("Quantas você quer?");
            var unidades = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Essa quantidade custa :{cerveja * unidades}"); 
        }

        public static void restoDivisao()
        {
            Console.WriteLine("\n RESTO DA DIVISAO % ");
            Console.WriteLine("------------------------");
            double valor = 10;
            int dividor = 2;
            Console.WriteLine($"Qual o resto da divisão de {valor} por {dividor} ?");

            double resto = valor % dividor;
            Console.WriteLine($"resto = {resto}");
            Console.WriteLine($"resto = { valor % dividor}");

             
            Console.WriteLine($"Para saber se um numero é par basta saber se a divisão por 2 não teve restos");
            Console.WriteLine("Informe um numero:");
            var numero1 = Int32.Parse(Console.ReadLine());
            if (numero1 % 2 == 0)
            {
                Console.WriteLine($"O numero {numero1} é par");
            }
            else
            {
                Console.WriteLine($"O numero {numero1} é impar");
            }


            Console.WriteLine("Informe outro numero:");
            var numero2 = Int32.Parse(Console.ReadLine());
            if (numero2 % 2 == 0)
            {
                Console.WriteLine($"O numero {numero2} é par");
            }
            else
            {
                Console.WriteLine($"O numero {numero2} é impar");
            }

        }

    }
}
