using FiscalNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return this.QuantidadeTributavel;
        }

        public decimal Valor()
        {
            return (this.QuantidadeTributavel * this.ValorCofinsUnitario);
        }
    }
}
