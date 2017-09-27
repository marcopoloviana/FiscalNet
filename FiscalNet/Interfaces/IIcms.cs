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

        decimal BaseIcms();
        decimal ValorIcms();

        decimal BaseIcmsST();
        decimal ValorIcmsST();
    }
}
