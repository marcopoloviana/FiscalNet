/*
 * NA REDUÇÃO DE BASE DE ICMS ST, CALCULA-SE A BASE DE ICMS SEM
 * IPI, E ACRESCENTA O IPI APÓS A REDUÇÃO DA BASE
 * 
 */
namespace FiscalNet.Implementacoes.Icms
{
    public class BaseReduzidaIcmsST
    {
        private decimal ValorProduto { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorSeguro { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorIpi { get; set; }
        private decimal ValorDesconto { get; set; }
        private decimal AliqRedBaseIcmsST { get; set; }

        public BaseReduzidaIcmsST(decimal valorProduto,
            decimal valorFrete,
            decimal valorSeguro,
            decimal despesasAcessorias,
            decimal valorIpi,
            decimal valorDesconto,
            decimal aliqRedBaseIcmsST)
        {
            this.ValorProduto       = valorProduto;
            this.ValorFrete         = valorFrete;
            this.ValorSeguro        = valorSeguro;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorIpi           = valorIpi;
            this.ValorDesconto      = valorDesconto;
            this.AliqRedBaseIcmsST  = aliqRedBaseIcmsST;
        }

        public decimal GerarBaseReduzidaIcmsST()
        {
            decimal BaseIcms = (ValorProduto +
                ValorFrete +
                ValorSeguro +
                DespesasAcessorias -
                ValorDesconto);

            return (BaseIcms - (BaseIcms * (AliqRedBaseIcmsST / 100))) + ValorIpi;
        }
    }
}
