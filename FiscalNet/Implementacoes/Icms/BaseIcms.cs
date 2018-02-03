namespace FiscalNet.Implementacoes.Icms
{
    public class BaseIcms
    {
        private decimal ValorProduto { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorSeguro { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorIpi { get; set; }
        private decimal ValorDesconto { get; set; }

        public BaseIcms(decimal valorProduto,
            decimal valorFrete,
            decimal valorSeguro,
            decimal despesasAcessorias,
            decimal valorIpi,
            decimal valorDesconto)
        {
            this.ValorProduto       = valorProduto;
            this.ValorFrete         = valorFrete;
            this.ValorSeguro        = valorSeguro;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorIpi           = valorIpi;
            this.ValorDesconto      = valorDesconto;
        }

        public decimal GerarBaseIcms()
        {
            decimal BaseIcms = (ValorProduto +
                ValorFrete +
                ValorSeguro +
                DespesasAcessorias +
                ValorIpi - 
                ValorDesconto);
            return BaseIcms;
        }
    }
}
