using FiscalNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNet.Implementacoes.Icms
{
    public class Icms51 : IIcms
    {
        private decimal AliqIcmsProprio { get; set; }
        private decimal AliqDifIcms { get; set; }
        private decimal ValorIpi { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorProduto { get; set; }
        private decimal ValorSeguro { get; set; }


        public Icms51(decimal aliqIcmsProprio, decimal aliqDifIcms,
            decimal valorIpi, decimal despesasAcessorias,
            decimal valorFrete, decimal valorProduto,
            decimal valorSeguro)
        {
            this.AliqIcmsProprio    = aliqIcmsProprio;
            this.AliqDifIcms        = aliqDifIcms;
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

        public decimal BaseIcms()
        {
            return new BaseIcms(ValorIpi, DespesasAcessorias, ValorFrete, ValorProduto, ValorSeguro).GerarBaseIcms();
        }

        public decimal ValorIcms()
        {
            BaseIcms vBcIcms = new BaseIcms(ValorIpi, DespesasAcessorias, ValorFrete, ValorProduto, ValorSeguro);

            ValorIcms valorIcms = new ValorIcms(AliqIcmsProprio, ValorIpi, DespesasAcessorias, ValorFrete, ValorProduto, ValorSeguro);

            return (valorIcms.GerarValorIcms() - ((valorIcms.GerarValorIcms() * (AliqDifIcms / 100)))); // icms final 70,00
        }

        //public decimal ValorIcms()
        //{
        //    BaseIcms vBcIcms = new BaseIcms(ValorIpi, DespesasAcessorias, ValorFrete, ValorProduto, ValorSeguro);

        //    ValorIcms valorIcms = new ValorIcms(AliqIcmsProprio, ValorIpi, DespesasAcessorias, ValorFrete, ValorProduto, ValorSeguro);

        //    //vIcmsOp = valorIcms.GerarValorIcms(); // icms da operacao  100,00
        //    //vIcmsDif = (valorIcms.GerarValorIcms() * (AliqDifIcms / 100)); // icms diferido 30,00

        //    return (valorIcms.GerarValorIcms() - ((valorIcms.GerarValorIcms() * (AliqDifIcms / 100)))); // icms final 70,00
        //}


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


        //public decimal ValorRedBaseIcms()
        //{
        //    throw new NotImplementedException();
        //}

        //public decimal ValorRedBaseIcmsST()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
