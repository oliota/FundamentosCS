using System;
using System.Collections.Generic;

namespace IntroducaoCS
{
    public class Exercicios
    {
        public void InformarDadosPessoais()
        {
            Console.WriteLine("Informe seus dados diretamente no codigo e exiba as informações em outro metodo privado ");
            Console.WriteLine("Obs: Use todos os tipos primitivos de variavies");
            string nome = "Rubem Oliota";
            int idade = 31;
            double peso = 105.5;
            decimal altura = 1.80m;
            float distanciaDoTrabalho = 5.5f;
            bool aniversarianteMes = false;

            ExibirDadosPessoais(nome, idade, peso, altura, distanciaDoTrabalho, aniversarianteMes);

            //Outra forma de passar os valores diretamente para o metodo
            //ExibirDadosPessoais("Rubem Oliota", 31, 105, 180, 5.5f, aniversarianteMes); 
        }

        public void CapturarDadosPessoais()
        {
            Console.WriteLine("Capture seus dados pessoais e exiba as informações em outro metodo privado ");
            Console.WriteLine("Obs: Use todos os tipos primitivos de variavies");

            Console.WriteLine("Informe seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe sua idade");
            int idade = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu peso(kg)");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua altura(M)");
            decimal altura = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a distancia da sua casa até o seu trabalho(km)");
            float distanciaDoTrabalho = float.Parse(Console.ReadLine());

            Console.WriteLine("Você faz aniversario nesse mês? (S/N)");
            bool aniversarianteMes = Console.ReadLine().ToUpper().Equals("S");

            ExibirDadosPessoais(nome, idade, peso, altura, distanciaDoTrabalho, aniversarianteMes);

        }

        public bool NumeroPar(int numero)
        {
            Console.WriteLine("Receba um numero por parametro e retorne se é par ");
            Console.WriteLine("o retorno deve ser tratado fora do metodo");

            return numero % 2 == 0;

        }

        public int ExibirApenasMultiplos(int multiplo, int limite)
        {
            Console.WriteLine("Receba um numero por parametro e a quantidade limite");
            Console.WriteLine("Exibir apenas os multiplos até a quantidade informada");
            Console.WriteLine("retornar a quantidade de numeros que atendem ao criterio");
            int contador = 0;
            for (int i = 1; i <= limite; i++)
            {
                if (i % multiplo == 0)
                {
                    Console.WriteLine($"{i} é multiplo de {multiplo}");
                    contador++;
                }
            } 
            return contador; 
        }

        private void ExibirDadosPessoais(string nome, int idade, double peso, decimal altura, float distanciaDoTrabalho, bool aniversarianteMes)
        {
            Console.WriteLine($"nome:{nome}");
            Console.WriteLine($"idade:{idade}");
            Console.WriteLine($"peso:{peso.ToString("F3")} Kg");
            Console.WriteLine($"altura:{altura.ToString("F")} M");
            Console.WriteLine($"Distancia do trabalho:{distanciaDoTrabalho.ToString("F3")} Km");
            Console.WriteLine($"Faço aniversario esse mês:{(aniversarianteMes ? "Sim" : "Não")}");
        }

        public void Capturar3_Notas_InformarMedia()
        {
            Console.WriteLine("Capture a nota de 3 alunos e informe a media");
            double nota1, nota2, nota3, media;

            Console.WriteLine("Informe a 1ª nota do aluno");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a 2ª nota do aluno");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a 3ª nota do aluno");
            nota3 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine($"Media : {media}");

            Console.WriteLine("Poderiamos melhorar a captura com um loop");
            Console.WriteLine("Se fossem notas de escola de samba o codigo ficaria enorme");

        }

        public void Capturar10_Notas_Com_For_InformarMedia()
        {
            double soma = 0;

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"Informe a {i}ª nota da escola de samba");
                soma += double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Media : {soma / 10}");
            Console.WriteLine("Poderiamos melhorar o divisor que esta fixo em 10");
            Console.WriteLine("Se fosse uma quantidade indefinida de registros não saberiamos o valor para calcular a media");
        }

        public void Capturar_N_Notas_Com_Do_Whille_List_InformarMedia()
        {
            var notas = new List<double>();
            double valor;
            double soma = 0;
            do
            {
                Console.WriteLine($"Informe uma nota (digite -1 para finalizar)");
                valor = double.Parse(Console.ReadLine());
                if (valor != -1)
                {
                    notas.Add(valor);
                    soma += valor;

                }
            } while (valor != -1);

            Console.WriteLine($"Media : {soma / notas.Count}");
            Console.WriteLine("Poderiamos melhorar o codigo ao não utilizar uma varivavel");
            Console.WriteLine("Se fosse uma quantidade indefinida de registros não saberiamos o valor para calcular a media");
        }

    }
}