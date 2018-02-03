using FiscalNet.Interfaces;

namespace FiscalNet.Implementacoes.Ipi
{
    class Ipi50Especifico : IIpi
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
            return this.QuantidadeTributavel;
        }

        public decimal Valor()
        {
            return (this.QuantidadeTributavel * this.ValorIpiUnitario);
        }
    }
}
