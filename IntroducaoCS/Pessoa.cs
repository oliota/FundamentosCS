using System;
using System.Collections.Generic;
using System.Text;
using static IntroducaoCS.CoresConsole;

namespace IntroducaoCS
{
    class Pessoa
    { 
        protected string Nome { get; set; }
        protected string Sobrenome { get; set; }
        protected DateTime DataNascimento { get; set; } 
        protected Cores CorFavorita { get; set; } 

    }
}
