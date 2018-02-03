namespace FiscalNet.Implementacoes.Icms
{
    public class ValorIcmsST
    {
        private decimal BaseCalculoST { get; set; }
        private decimal AliqIcmsST { get; set; }
        private decimal ValorIcms { get; set; }

        public ValorIcmsST(decimal baseCalculoST, decimal aliqIcmsST, decimal valorIcms)
        {
            this.BaseCalculoST  = baseCalculoST;
            this.AliqIcmsST     = aliqIcmsST;
            this.ValorIcms      = valorIcms;
        }

        public decimal GerarValorIcmsST()
        {
            return ((BaseCalculoST * (AliqIcmsST / 100)) - ValorIcms);
        }
    }
}
