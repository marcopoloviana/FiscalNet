namespace FiscalNet.Interfaces
{
    public interface IIcms
    {
        bool PossuiIcmsProprio { get; }
        bool PossuiIcmsST { get; }
        bool PossuiRedBCIcmsProprio { get; }
        bool PossuiRedBCIcmsST { get; }

        decimal BaseIcms();
        decimal ValorIcms();

        decimal BaseIcmsST();
        decimal ValorIcmsST();
    }
}
