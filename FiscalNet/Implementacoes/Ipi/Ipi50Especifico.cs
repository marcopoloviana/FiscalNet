using FiscalNet.Interfaces;

namespace FiscalNet.Implementacoes.Ipi
{
    public class Ipi50Especifico : IIpi
    {
        private decimal ValorIpiUnitario { get; set; }
        private decimal QuantidadeTributavel { get; set; }        

        public Ipi50Especifico(decimal valorIpiUnitario,
            decimal quantidadeTributavel)
        {
            this.ValorIpiUnitario = valorIpiUnitario;
            this.QuantidadeTributavel = quantidadeTributavel;            
        }
        public decimal BaseCalculo()
        {
            return QuantidadeTributavel;
        }

        public decimal Valor()
        {
            return (QuantidadeTributavel * ValorIpiUnitario);
        }
    }
}
