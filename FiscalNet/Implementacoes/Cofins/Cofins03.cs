using FiscalNet.Interfaces;

namespace FiscalNet.Implementacoes.Cofins
{
    public class Cofins03 : ICofins
    {
        private decimal ValorCofinsUnitario { get; set; }
        private decimal QuantidadeTributavel { get; set; }

        public Cofins03(decimal valorCofinsUnitario,
            decimal quantidadeTributavel)
        {
            this.ValorCofinsUnitario = valorCofinsUnitario;
            this.QuantidadeTributavel = quantidadeTributavel;
        }
        public decimal BaseCalculo()
        {
            return QuantidadeTributavel;
        }

        public decimal Valor()
        {
            return (QuantidadeTributavel * ValorCofinsUnitario);
        }
    }
}
