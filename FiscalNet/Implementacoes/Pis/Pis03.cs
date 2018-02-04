using FiscalNet.Interfaces;

namespace FiscalNet.Implementacoes.Pis
{
    public class Pis03 : IPis
    {
        private decimal ValorPisUnitario { get; set; }
        private decimal QuantidadeTributavel { get; set; }

        public Pis03(decimal valorPisUnitario,
            decimal quantidadeTributavel)
        {
            this.ValorPisUnitario = valorPisUnitario;
            this.QuantidadeTributavel = quantidadeTributavel;
        }
        public decimal BaseCalculo()
        {
            return QuantidadeTributavel;
        }

        public decimal Valor()
        {
            return (QuantidadeTributavel * ValorPisUnitario);
        }
    }
}
