using FiscalNet.Interfaces;

namespace FiscalNet.Implementacoes.Ipi
{
    public class Ipi50 : IIpi
    {
        private decimal ValorProduto { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorSeguro { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal AliqIpi { get; set; }

        public Ipi50(decimal valorProduto,
            decimal valorFrete,
            decimal valorSeguro,
            decimal despesasAcessorias,
            decimal aliqIpi)
        {
            this.ValorProduto       = valorProduto;
            this.ValorFrete         = valorFrete;
            this.ValorSeguro        = valorSeguro;
            this.DespesasAcessorias = despesasAcessorias;
            this.AliqIpi            = aliqIpi;
        }

        public decimal BaseCalculo()
        {
            decimal BaseIpi = (ValorProduto +
                ValorFrete +
                ValorSeguro +
                DespesasAcessorias);
            return BaseIpi;
        }

        public decimal Valor()
        {           
            return ((AliqIpi / 100) * BaseCalculo());
        }
    }
}
