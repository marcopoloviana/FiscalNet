using System;

namespace FiscalNet.Implementacoes.IcmsExceptions
{
    public  class SemBasePropriaException : Exception
    {
        public override string Message
        {
            get
            {
                return @"Este CST/CSOSN não possui base ou valor própria de ICMS.
Verifique a propriedade 'PossuiIcmsProprio' antes de acionar o método de cálculo.";
            }
        }
    }
}
