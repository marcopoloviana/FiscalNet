using FiscalNet.Implementacoes.IcmsExceptions;
using FiscalNet.Interfaces;

namespace FiscalNet.Implementacoes.Icms
{
    public class Icms300_400_500 : IIcms
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

        public decimal BaseIcms()
        {
            throw new SemBasePropriaException();
        }

        public decimal BaseIcmsST()
        {
            throw new SemICMSSTException();
        }

        public decimal PercRedBaseIcms()
        {
            throw new SemRedBaseIcmsException();
        }

        public decimal PercRedBaseIcmsST()
        {
            throw new SemRedBaseIcmsSTException();
        }

        public decimal ValorIcms()
        {
            throw new SemBasePropriaException();
        }

        public decimal ValorIcmsST()
        {
            throw new SemICMSSTException();
        }
    }
}
