using FiscalNet.Implementacoes.IcmsExceptions;
using FiscalNet.Interfaces;

namespace FiscalNet.Implementacoes.Icms
{
    public class Icms101_102_103 : IIcms
    {
        public bool PossuiIcmsProprio
        {
            get
            {
                return false;
            }
        }

        public bool PossuiIcmsST
        {
            get
            {
                return false;
            }
        }

        public bool PossuiRedBCIcmsProprio
        {
            get
            {
                return false;
            }
        }

        public bool PossuiRedBCIcmsST
        {
            get
            {
                return false;
            }
        }

        public Icms101_102_103(int csosn)
        {

        }

        public decimal BaseIcms()
        {
            throw new SemBasePropriaException();
        }

        public decimal ValorIcms()
        {
            throw new SemBasePropriaException();
        }

        public decimal BaseIcmsST()
        {
            throw new SemICMSSTException();
        }

        public decimal ValorIcmsST()
        {
            throw new SemICMSSTException();
        }
    }
}
