using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNet.Implementacoes.Icms
{
    public class ValorIcms
    {
        private decimal AliqIcmsProprio { get; set; }
        private decimal ValorIpi { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorProduto { get; set; }
        private decimal ValorSeguro { get; set; }

        public ValorIcms(decimal aliqIcmsProprio,
            decimal valorIpi, decimal despesasAcessorias,
            decimal valorFrete, decimal valorProduto, decimal valorSeguro)
        {
            this.AliqIcmsProprio    = aliqIcmsProprio;
            this.ValorIpi           = valorIpi;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorFrete         = valorFrete;
            this.ValorProduto       = valorProduto;
            this.ValorSeguro        = valorSeguro;

        }


        public decimal GerarValorIcms()
        {
            /* 
            * (Base do ICMS Proprio * (Alíquota do ICMS Proprio / 100))
            * */

            BaseIcms bcIcms = new BaseIcms(ValorIpi, DespesasAcessorias, ValorFrete, ValorProduto, ValorSeguro);

            return  (AliqIcmsProprio / 100 * bcIcms.GerarBaseIcms());

        }
    }
}
