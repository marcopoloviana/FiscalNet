using FiscalNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public decimal PercRedBaseIcms()
        {
            return Icms.PercRedBaseIcms();
        }

        public decimal PercRedBaseIcmsST()
        {
            return Icms.PercRedBaseIcmsST();
        }

        public decimal ValorIcms()
        {
            return Icms.ValorIcms();
        }

        public decimal ValorIcmsST()
        {
            return Icms.ValorIcmsST();
        }

        public decimal ValorRedBaseIcms()
        {
            return Icms.ValorRedBaseIcms();
        }

        public decimal ValorRedBaseIcmsST()
        {
            return Icms.ValorRedBaseIcmsST();
        }
    }
}
