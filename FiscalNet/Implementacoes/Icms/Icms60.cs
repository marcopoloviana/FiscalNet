using FiscalNET.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNet.Implementacoes.Icms
{
    public class Icms60 : IIcms
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
            throw new NotImplementedException();
        }

        public decimal BaseIcmsST()
        {
            throw new NotImplementedException();
        }

        public decimal PercRedBaseIcms()
        {
            throw new NotImplementedException();
        }

        public decimal PercRedBaseIcmsST()
        {
            throw new NotImplementedException();
        }

        public decimal ValorIcms()
        {
            throw new NotImplementedException();
        }

        public decimal ValorIcmsST()
        {
            throw new NotImplementedException();
        }

        public decimal ValorRedBaseIcms()
        {
            throw new NotImplementedException();
        }

        public decimal ValorRedBaseIcmsST()
        {
            throw new NotImplementedException();
        }
    }
}
