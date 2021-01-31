using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IntroducaoCS
{
    class Aluno : Pessoa
    {
        private string Curso { get; set; }
        private string Matricula { get; set; }
        private string Instrutor { get; set; } 
        public enum TipoEscolaridade
        {
            [Description("Ensino médio")]
            EnsinoMedio = 1,
            [Description("Ensino superior - cursando")]
            Graduando = 2,
            [Description("Ensino superior - formado")]
            Graduado = 3
        }
        private TipoEscolaridade Escolaridade;

        private List<string> InteressesPessoais { get; set; }

        public void DadosFixos()
        {
            Nome = "Rubem";
            Sobrenome = "Oliota";
            DataNascimento = new DateTime(1989,04,08);
            CorFavorita = CoresConsole.Cores.Verde;

            Curso = "Fundamentos C#";
            Matricula = "20210130";
            Instrutor = "Rubem Oliota";
            Escolaridade = TipoEscolaridade.Graduado;
            InteressesPessoais = new List<string>(); 
            InteressesPessoais.Add("Basquete");
            InteressesPessoais.Add("Artesanato em biscuit");
            InteressesPessoais.Add("Desenvolver aplicativos android");
            InteressesPessoais.Add("Robotica com lego");
            InteressesPessoais.Add("Invenções");
            InteressesPessoais.Add("Tecnologia");

        }
        public void MeApresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome} {Sobrenome} e tenho {CalcularIdade()} anos.");
            Console.WriteLine($"Minha cor favorita é: ");
             DestacarCorFavorita() ;
            Console.WriteLine($"No momento estou assistindo aulas no curso {Curso} com o instrutor {Instrutor}");
            Console.WriteLine($"Minha matricula é {Matricula}");
            Console.WriteLine($"Meu nível de escolaridade é {DescreverEnum(Escolaridade)}");
            Console.WriteLine($"Meus interesses pessoais são:");  
            Console.WriteLine($"{ListarInteressesPessoais()}");
            Utils.Pausar("Isso é só um pouco sobre mim, tem alguma pergunta? Se não tiver digite ENTER para prosseguir.");
             
        }

        private void DestacarCorFavorita()
        {
            var CorAtual = Console.ForegroundColor;
            Console.ForegroundColor = (ConsoleColor)CorFavorita;
            Console.WriteLine(CorFavorita);
            Console.ForegroundColor = CorAtual;
        }

        private object ListarInteressesPessoais()
        {

            StringBuilder sb = new StringBuilder();

            foreach (var item in InteressesPessoais)
            {
                sb.AppendLine($"\t- {item}");
            }
            return sb.ToString();
        }

        private int CalcularIdade()
        {
            return System.DateTime.Now.Year - DataNascimento.Year;
        }


        public string DescreverEnum(TipoEscolaridade val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}
