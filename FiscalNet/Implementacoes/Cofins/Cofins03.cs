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
        private decimal AliqEspecificaCofins { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorProduto { get; set; }
        private decimal ValorSeguro { get; set; }
        private decimal QuantidadeProduto { get; set; }

        public Cofins03(decimal aliqEspecificaCofins,
            decimal despesasAcessorias,
            decimal valorFrete, decimal valorProduto,
            decimal valorSeguro, decimal quantidadeProduto)
        {
            this.AliqEspecificaCofins = aliqEspecificaCofins;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorFrete = valorFrete;
            this.ValorProduto = valorProduto;
            this.ValorSeguro = valorSeguro;
            this.QuantidadeProduto = quantidadeProduto;

        }
        public decimal BaseCalculo()
        {
            decimal BasePis = this.QuantidadeProduto;
            return BasePis;
        }

        public decimal Valor()
        {
            return (this.BaseCalculo() * AliqEspecificaCofins);
        }
    }
}
