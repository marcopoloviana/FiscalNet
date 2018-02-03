using System;

namespace FiscalNet.Implementacoes.IcmsExceptions
{
    public class SemICMSSTException : Exception
    {
        public override string Message
        {
            get
            {
                return @"Este CST/CSOSN não possui base ou valor de ICMS-ST.
Verifique a propriedade 'PossuiIcmsST' antes de acionar o método de cálculo.";
            }
        }
    }
}
