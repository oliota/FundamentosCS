using System;
using System.Collections.Generic;
using System.Text;

namespace IntroducaoCS
{
    class Utils
    {

        static public void Pausar()
        {
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadLine();
        }
        static public void Pausar(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.ReadLine();
        }
        static public void Pausar(bool exigirEducacao)
        {
            if (exigirEducacao)
            {
                do
                {
                    Console.WriteLine("Seja educado, qual a palavra magica para sair?");
                } while (!Console.ReadLine().ToLower().Equals("por favor"));

            }
            else
            {
                Console.WriteLine("Finalizando o programa, fica tranquilo não precisa dizer 'por favor'");
            }

        }
        static public bool ObterAprovacao(string pergunta)
        {
            Console.WriteLine($"{pergunta} (S/N)");
            var input = Console.ReadLine();
            return (input.ToLower().Equals("s"));
        }

      
    }
}
