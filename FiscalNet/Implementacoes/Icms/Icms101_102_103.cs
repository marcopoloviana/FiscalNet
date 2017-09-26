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
        public Icms101_102_103(int csosn)
        {

        }

        public decimal BaseIcms()
        {
            return 0;
        }

        public decimal BaseIcmsST()
        {
            throw new NotImplementedException();
        }

        public decimal ValorIcms()
        {
            return 0;
        }

        public decimal ValorIcmsST()
        {
            throw new NotImplementedException();
        }
    }
}
