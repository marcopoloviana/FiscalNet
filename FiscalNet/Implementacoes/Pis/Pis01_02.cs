using FiscalNET.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNet.Implementacoes.Pis
{
    public class Pis01_02 : IPis
    {

        private decimal AliqPis { get; set; }
        private decimal ValorIpi { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorProduto { get; set; }
        private decimal ValorSeguro { get; set; }

        public Pis01_02(decimal aliqPis,
            decimal despesasAcessorias,
            decimal valorFrete, decimal valorProduto,
            decimal valorSeguro)
        {
            this.AliqPis = aliqPis;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorFrete         = valorFrete;
            this.ValorProduto       = valorProduto;
            this.ValorSeguro        = valorSeguro;

        }
        public decimal BaseCalculo()
        {
            decimal BasePis = (ValorProduto +
                ValorFrete +
                ValorSeguro +
                DespesasAcessorias);
            return BasePis;
        }

        public decimal Valor()
        {
            return (this.BaseCalculo() * (AliqPis / 100));
        }
    }
}
