namespace FiscalNet.Implementacoes.Icms
{
    public class ValorIcms
    {
        private decimal BaseCalculo { get; set; }
        private decimal AliqIcmsProprio { get; set; }

        public ValorIcms(decimal baseCalculo, 
            decimal aliqIcmsProprio)
        {
            this.BaseCalculo = baseCalculo;
            this.AliqIcmsProprio = aliqIcmsProprio;
        }

        public decimal GerarValorIcms()
        {
            return  (AliqIcmsProprio / 100 * BaseCalculo);
        }
    }
}
