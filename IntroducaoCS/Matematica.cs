using System;
using System.Collections.Generic;
using System.Text;

namespace IntroducaoCS
{
    public class Matematica
    {
        private double numero1 = 0;

        private double numero2 = 0;

        public delegate void MatematicaDelegate();

        public void InformarNumeros()
        {
            Console.WriteLine("Informe o primeiro numero");
            numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero");
            numero2 = double.Parse(Console.ReadLine());
        }
 
        public void Somar()
        {
            Console.WriteLine($" Somar {numero1} + {numero2} =  {numero1 + numero2}");
        }

        public void Subtrair()
        {
            Console.WriteLine($" Subtrair {numero1} - {numero2} =  {numero1 - numero2}");
        }

        public void Multiplicar()
        {
            Console.WriteLine($" Multiplicar {numero1} * {numero2} =  {numero1 * numero2}");
        }

        public void Dividir()
        {
            Console.WriteLine($" Dividir {numero1} / {numero2} =  {numero1 / numero2}");
        }
    }
}
