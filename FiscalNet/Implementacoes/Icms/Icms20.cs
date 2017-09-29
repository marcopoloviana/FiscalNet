using FiscalNet.Implementacoes.IcmsExceptions;
using FiscalNET.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNet.Implementacoes.Icms
{
    class Icms20 : IIcms
    {
        private decimal AliqIcmsProprio { get; set; }
        private decimal AliqRedBcIcms { get; set; }
        private decimal ValorIpi { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorProduto { get; set; }
        private decimal ValorSeguro { get; set; }

        public Icms20(decimal aliqIcmsProprio, decimal aliqRedBcIcms,
            decimal valorIpi, decimal despesasAcessorias,
            decimal valorFrete, decimal valorProduto,
            decimal valorSeguro)
        {
            this.AliqIcmsProprio    = aliqIcmsProprio;
            this.AliqRedBcIcms      = aliqRedBcIcms; 
            this.ValorIpi           = valorIpi;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorFrete         = valorFrete;
            this.ValorProduto       = valorProduto;
            this.ValorSeguro        = valorSeguro;
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
                return false;
            }
        }

        public bool PossuiRedBCIcmsProprio
        {
            get
            {
                return true;
            }
        }

        public bool PossuiRedBCIcmsST
        {
            get
            {
                return false;
            }
        }

        public decimal ValorRedBaseIcms()
        {
            return new BaseReduzidaIcms(ValorIpi, DespesasAcessorias, ValorFrete, ValorProduto, ValorSeguro, AliqRedBcIcms).GerarBaseReduzidaIcms();
        }

        public decimal ValorIcms()
        {
            BaseIcms vBcIcms    = new BaseIcms(ValorIpi, DespesasAcessorias, ValorFrete, ValorProduto, ValorSeguro);

            BaseReduzidaIcms vBcRedIcms = new BaseReduzidaIcms(ValorIpi, DespesasAcessorias, ValorFrete, ValorProduto, ValorSeguro, AliqRedBcIcms);
            decimal vBaseRedIcms = vBcRedIcms.GerarBaseReduzidaIcms();

            return (AliqIcmsProprio / 100) * vBaseRedIcms;

        }

        public decimal BaseIcmsST()
        {
            throw new NotImplementedException();
        }

        public decimal PercRedBaseIcms()
        {
            throw new NotImplementedException();
        }

        public decimal PercRedBaseIcmsST()
        {
            throw new NotImplementedException();
        }        

        public decimal ValorIcmsST()
        {
            throw new NotImplementedException();
        }        

        public decimal ValorRedBaseIcmsST()
        {
            throw new NotImplementedException();
        }

        public decimal BaseIcms()
        {
            throw new NotImplementedException();
        }
    }
}
