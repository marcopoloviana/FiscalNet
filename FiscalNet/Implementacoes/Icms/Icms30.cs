/*
 * O CST 30 CALCULA O ICMS PROPRIO POREM NAO SERA DESTACADO NA NF
 * BASE DE ICMS PROPRIO NEM VALOR DE ICMS PROPRIO, APENAS DESTACARÁ
 * BASE DE ICMS ST E VALOR DE ICMS ST
 * 
 */

using FiscalNet.Implementacoes.IcmsExceptions;
using FiscalNet.Interfaces;

namespace FiscalNet.Implementacoes.Icms
{
    public class Icms30 : IIcms
    {
        private decimal ValorProduto { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorSeguro { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorIpi { get; set; }
        private decimal ValorDesconto { get; set; }
        private decimal AliqIcmsProprio { get; set; }
        private decimal AliqIcmsST { get; set; }
        private decimal Mva { get; set; }

        private BaseIcms BaseCalculo { get; set; }

        public Icms30(decimal valorProduto,
            decimal valorFrete,
            decimal valorSeguro,
            decimal despesasAcessorias,
            decimal valorIpi,
            decimal valorDesconto,
            decimal aliqIcmsProprio,
            decimal aliqIcmsST,
            decimal mva)
        {
            this.ValorProduto       = valorProduto;
            this.ValorFrete         = valorFrete;
            this.ValorSeguro        = valorSeguro;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorIpi           = valorIpi;
            this.ValorDesconto      = valorDesconto;
            this.AliqIcmsProprio    = aliqIcmsProprio;
            this.AliqIcmsST         = aliqIcmsST;
            this.Mva                = mva;
            this.BaseCalculo        = new BaseIcms(ValorProduto, ValorFrete, ValorSeguro, DespesasAcessorias, ValorIpi, ValorDesconto);
        }
        public bool PossuiIcmsProprio
        {
            get
            {
                return true;
            }
        }

        public bool PossuiIcmsST
        {
            get
            {
                return true;
            }
        }

        public bool PossuiRedBCIcmsProprio
        {
            get
            {
                return false;
            }
        }

        public bool PossuiRedBCIcmsST
        {
            get
            {
                return false;
            }
        }


        public decimal BaseIcms()
        {
            return BaseCalculo.GerarBaseIcms();
        }

        public decimal ValorIcms()
        {
            return new ValorIcms(BaseIcms(), AliqIcmsProprio).GerarValorIcms();
        }

        public decimal BaseIcmsST()
        {
            return new BaseIcmsST(BaseIcms(), Mva).GerarBaseIcmsST();
        }

        public decimal ValorIcmsST()
        {
            return new ValorIcmsST(BaseIcmsST(), AliqIcmsST, ValorIcms()).GerarValorIcmsST();
        }

        public decimal ValorRedBaseIcms()
        {
            throw new SemRedBaseIcmsException();
        }

        public decimal ValorRedBaseIcmsST()
        {
            throw new SemRedBaseIcmsSTException();
        }
    }
}
