using FiscalNet.Interfaces;

namespace FiscalNet.Implementacoes.Cofins
{
    public class Cofins01_02 : ICofins
    {
        private decimal ValorProduto { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorSeguro { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorDesconto { get; set; }
        private decimal AliqCofins { get; set; }

        public Cofins01_02(decimal valorProduto,
            decimal valorFrete, 
            decimal valorSeguro, 
            decimal despesasAcessorias,
            decimal valorDesconto,
            decimal aliqCofins)
        {
            this.ValorProduto = valorProduto;
            this.ValorFrete = valorFrete;
            this.ValorSeguro = valorSeguro;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorDesconto = valorDesconto;
            this.AliqCofins = aliqCofins;
        }

        public decimal BaseCalculo()
        {
            decimal Base = (ValorProduto +
                ValorFrete +
                ValorSeguro +
                DespesasAcessorias -
                ValorDesconto);
            return Base;
        }

        public decimal Valor()
        {
            return (this.BaseCalculo() * (AliqCofins * 0.01M));
        }
    }
}
