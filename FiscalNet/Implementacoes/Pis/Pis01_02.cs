using FiscalNet.Interfaces;

namespace FiscalNet.Implementacoes.Pis
{
    public class Pis01_02 : IPis
    {
        private decimal ValorProduto { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorSeguro { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorDesconto { get; set; }
        private decimal AliqPis { get; set; }

        public Pis01_02(decimal valorProduto,
            decimal valorFrete,
            decimal valorSeguro,
            decimal despesasAcessorias,
            decimal valorDesconto, 
            decimal aliqPis)
        {
            this.ValorProduto       = valorProduto;
            this.ValorFrete         = valorFrete;
            this.ValorSeguro        = valorSeguro;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorDesconto      = valorDesconto;
            this.AliqPis            = aliqPis;

        }
        public decimal BaseCalculo()
        {
            decimal BasePis = (ValorProduto +
                ValorFrete +
                ValorSeguro +
                DespesasAcessorias -
                ValorDesconto);
            return BasePis;
        }

        public decimal Valor()
        {
            return (BaseCalculo() * (AliqPis / 100));
        }
    }
}
