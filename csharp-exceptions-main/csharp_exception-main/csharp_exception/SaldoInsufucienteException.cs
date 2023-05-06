using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exception
{
    public class SaldoInsufucienteException : Exception
    {
        public SaldoInsufucienteException(string mensagem) : base(mensagem) 
        {

        }
    }
}
