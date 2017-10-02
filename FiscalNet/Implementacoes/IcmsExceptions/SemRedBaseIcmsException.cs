using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNet.Implementacoes.IcmsExceptions
{
    public class SemRedBaseIcmsException : Exception
    {
        public override string Message
        {
            get
            {
                return @"Este CST/CSOSN não possui redução de base de ICMS.
Verifique a propriedade 'PossuiRedBCIcmsProprio' antes de acionar o método de cálculo.";
            }
        }
    }
}
