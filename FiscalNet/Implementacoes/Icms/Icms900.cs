using FiscalNet.Interfaces;

namespace FiscalNet.Implementacoes.Icms
{
    public class Icms900 : IIcms
    {
        private IIcms Icms { get; set; }
        public Icms900(IIcms icms)
        {
           this.Icms = icms;
        }

        public bool PossuiIcmsProprio
        {
            get
            {
                return Icms.PossuiIcmsProprio;
            }
        }

        public bool PossuiIcmsST
        {
            get
            {
                return Icms.PossuiIcmsST;
            }
        }

        public bool PossuiRedBCIcmsProprio
        {
            get
            {
                return Icms.PossuiRedBCIcmsProprio;
            }
        }

        public bool PossuiRedBCIcmsST
        {
            get
            {
                return Icms.PossuiRedBCIcmsST;
            }
        }

        public decimal BaseIcms()
        {
            return Icms.BaseIcms();
        }

        public decimal BaseIcmsST()
        {
            return Icms.BaseIcmsST();
        }

        public decimal ValorIcms()
        {
            return Icms.ValorIcms();
        }

        public decimal ValorIcmsST()
        {
            return Icms.ValorIcmsST();
        }
    }
}
