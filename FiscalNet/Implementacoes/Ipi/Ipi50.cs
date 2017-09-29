using FiscalNet.Implementacoes.IpiExceptions;
using FiscalNET.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNet.Implementacoes.Ipi
{
    public class Ipi50 : IIpi
    {
        private decimal AliqIpi { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorProduto { get; set; }
        private decimal ValorSeguro { get; set; }

        public Ipi50(decimal aliqIpi,
             decimal despesasAcessorias,
            decimal valorFrete, decimal valorProduto,
            decimal valorSeguro)
        {
            this.AliqIpi            = aliqIpi;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorFrete         = valorFrete;
            this.ValorProduto       = valorProduto;
            this.ValorSeguro        = valorSeguro;
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
            Ipi50 bcIpi = new Ipi50(AliqIpi, DespesasAcessorias, ValorFrete, ValorProduto, ValorSeguro);

            return ((AliqIpi / 100) * bcIpi.BaseCalculo());
        }
    }
}
