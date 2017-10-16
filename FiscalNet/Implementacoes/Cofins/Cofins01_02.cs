using FiscalNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNet.Implementacoes.Cofins
{
    public class Cofins01_02 : ICofins
    {
        private decimal AliqCofins { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorProduto { get; set; }
        private decimal ValorSeguro { get; set; }
        private decimal ValorIpi { get; set; }

        public Cofins01_02(decimal aliqCofins,
            decimal despesasAcessorias,
            decimal valorFrete, decimal valorProduto,
            decimal valorSeguro, decimal valorIpi)
        {
            this.AliqCofins = aliqCofins;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorFrete = valorFrete;
            this.ValorProduto = valorProduto;
            this.ValorSeguro = valorSeguro;
            this.ValorIpi = valorIpi;

        }
        public decimal BaseCalculo()
        {
            decimal BasePis = (ValorProduto +
                ValorFrete +
                ValorSeguro +
                DespesasAcessorias +
                ValorIpi);
            return BasePis;
        }

        public decimal Valor()
        {
            return (this.BaseCalculo() * (AliqCofins / 100));
        }
    }
}
