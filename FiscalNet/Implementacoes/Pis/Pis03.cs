using FiscalNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return this.QuantidadeTributavel;
        }

        public decimal Valor()
        {
            return (this.QuantidadeTributavel * this.ValorPisUnitario);
        }
    }
}
