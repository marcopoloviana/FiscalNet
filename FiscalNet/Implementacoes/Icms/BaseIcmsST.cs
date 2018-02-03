namespace FiscalNet.Implementacoes.Icms
{
    public class BaseIcmsST
    {
        private decimal BaseIcms { get; set; }
        private decimal MVA { get; set; }

        public BaseIcmsST(decimal baseIcms, decimal mva)
        {
            this.BaseIcms = baseIcms;
            this.MVA      = mva;
        }

        public decimal GerarBaseIcmsST()
        {
            return (BaseIcms) * (1 + (MVA / 100));
        }
    }
}
