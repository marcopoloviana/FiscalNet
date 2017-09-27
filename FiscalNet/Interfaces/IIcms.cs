using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNET.Interfaces
{
    public interface IIcms
    {
        bool PossuiIcmsProprio { get; }
        bool PossuiIcmsST { get; }
        bool PossuiRedBCIcmsProprio { get; }
        bool PossuiRedBCIcmsST { get; }

        decimal BaseIcms();
        decimal ValorIcms();

        decimal PercRedBaseIcms();
        decimal ValorRedBaseIcms();

        decimal PercRedBaseIcmsST();
        decimal ValorRedBaseIcmsST();

        decimal BaseIcmsST();
        decimal ValorIcmsST();
    }
}
