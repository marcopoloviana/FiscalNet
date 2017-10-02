using FiscalNet.Implementacoes.IcmsExceptions;
using FiscalNET.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNet.Implementacoes.Icms
{
    public class SemIcms : IIcms
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

        public decimal ValorRedBaseIcms()
        {
            throw new SemRedBaseIcmsException();
        }

        public decimal ValorRedBaseIcmsST()
        {
            throw new SemRedBaseIcmsSTException();
        }
    }
}
