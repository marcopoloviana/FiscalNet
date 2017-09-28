using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNet.Implementacoes.Icms
{

    public class ValorIcmsST
    {
        private decimal AliqIcmsProprio { get; set; }
        private decimal AliqIcmsST { get; set; }
        private decimal ValorIpi { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorProduto { get; set; }
        private decimal ValorSeguro { get; set; }
        private decimal Mva { get; set; }


        public ValorIcmsST(decimal aliqIcmsProprio,
            decimal aliqIcmsST, decimal valorIpi, decimal despesasAcessorias,
            decimal valorFrete, decimal mva, decimal valorProduto,
            decimal valorSeguro)
        {
            this.AliqIcmsProprio    = aliqIcmsProprio;
            this.AliqIcmsST         = aliqIcmsST;
            this.ValorIpi           = valorIpi;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorFrete         = valorFrete;
            this.ValorProduto       = valorProduto;
            this.ValorSeguro        = valorSeguro;
            this.Mva = mva;
        }

        public decimal GerarValorIcmsST()
        {
            /* 
            * (Base do ICMS ST * (Alíquota do ICMS Interno / 100)) – Valor do ICMS Próprio
            * */

            BaseIcmsST bcIcmsST = new BaseIcmsST(ValorIpi, DespesasAcessorias,ValorFrete, Mva, ValorProduto,ValorSeguro);
            ValorIcms vIcms = new ValorIcms(AliqIcmsProprio,ValorIpi, DespesasAcessorias,ValorFrete, ValorProduto, ValorSeguro);

            return ((bcIcmsST.GerarBaseIcmsST() * (AliqIcmsST / 100)) - vIcms.GerarValorIcms());

        }

    }
}
