using System;
using System.Collections.Generic;
using System.Text;

namespace EX_execoes.Classes
{
    class Ex : ApplicationException
    {
        public Ex(string Mensagem) : base(Mensagem) 
        { 
        }
    }
}
