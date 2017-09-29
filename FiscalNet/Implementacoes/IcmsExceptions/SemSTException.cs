using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNet.Implementacoes.IpiExceptions
{
    public class SemSTException : Exception
    {
        public override string Message
        {
            get
            {
                return @"Este CST/CSOSN não possui base ou valor de ICMS para substituição tributária.
Verifique a propriedade 'PossuiIcmsST' antes de acionar o método de cálculo.";
            }
        }
    }
}
