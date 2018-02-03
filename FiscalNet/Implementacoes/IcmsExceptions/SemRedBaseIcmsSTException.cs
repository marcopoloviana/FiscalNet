using System;

namespace FiscalNet.Implementacoes.IcmsExceptions
{
    class SemRedBaseIcmsSTException : Exception
    {
        public override string Message
        {
            get
            {
                return @"Este CST/CSOSN não possui redução de base de ICMS-ST.
Verifique a propriedade 'PossuiRedBCIcmsST' antes de acionar o método de cálculo.";
            }
        }
    }
}
