using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNet.Implementacoes.Icms
{
    public class BaseIcms
    {        
        private decimal ValorIpi { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorProduto { get; set; }
        private decimal ValorSeguro { get; set; }

        public BaseIcms(decimal valorIpi, 
            decimal despesasAcessorias,
            decimal valorFrete, decimal valorProduto,
            decimal valorSeguro)
        {
            this.ValorIpi = valorIpi;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorFrete = valorFrete;
            this.ValorProduto = valorProduto;
            this.ValorSeguro = valorSeguro;
        }

        public decimal GerarBaseIcms()
        {
            /*
            * Base do ICMS Inter = (Valor do produto +
            *  Frete +
            *   Seguro + 
            *   Outras Despesas Acessórias – Descontos)
            * */

            decimal BaseIcms = (ValorProduto +
                ValorFrete +
                ValorSeguro +
                DespesasAcessorias);
            return BaseIcms;
        }
    }
}
