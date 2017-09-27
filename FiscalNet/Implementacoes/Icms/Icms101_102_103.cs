using FiscalNet.Implementacoes.IcmsExceptions;
using FiscalNET.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                throw new NotImplementedException();
            }
        }

        public bool PossuiRedBCIcmsST
        {
            get
            {
                throw new NotImplementedException();
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
            throw new SemSTException();
        }

        public decimal ValorIcmsST()
        {
            throw new SemSTException();
        }

        public decimal PercRedBaseIcms()
        {
            throw new NotImplementedException();
        }

        public decimal ValorRedBaseIcms()
        {
            throw new NotImplementedException();
        }

        public decimal PercRedBaseIcmsST()
        {
            throw new NotImplementedException();
        }

        public decimal ValorRedBaseIcmsST()
        {
            throw new NotImplementedException();
        }
    }
}
