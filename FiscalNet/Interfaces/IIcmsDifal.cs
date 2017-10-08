using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNet.Interfaces
{
    public interface IIcmsDifal
    {
        decimal BaseIcms();
        decimal ValorFcpDestino();
        decimal ValorDifal();
        decimal ValorIcmsDestino();
        decimal ValorIcmsRemetente();
       
    }
}
