using FiscalNet.Implementacoes.IcmsExceptions;
using FiscalNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNet.Implementacoes.Icms
{
    public class Icms00 : IIcms
    {
        private decimal AliqIcmsProprio { get; set; }
        private decimal ValorIpi { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorProduto { get; set; }
        private decimal ValorSeguro { get; set; }

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

        public Icms00(decimal aliqIcmsProprio,
            decimal valorIpi, decimal despesasAcessorias,
            decimal valorFrete, decimal valorProduto,
            decimal valorSeguro)
        {
            this.AliqIcmsProprio    = aliqIcmsProprio;
            this.ValorIpi           = valorIpi;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorFrete         = valorFrete;
            this.ValorProduto       = valorProduto;
            this.ValorSeguro        = valorSeguro;
        }

        public decimal BaseIcms()
        {
            return new BaseIcms(ValorIpi, DespesasAcessorias, ValorFrete, ValorProduto, ValorSeguro).GerarBaseIcms();
        }        

        public decimal ValorIcms()
        {            
            return new ValorIcms(AliqIcmsProprio,ValorIpi, DespesasAcessorias,ValorFrete, ValorProduto, ValorSeguro).GerarValorIcms();
        }

        public decimal BaseIcmsST()
        {
            throw new SemICMSSTException();
        }

        public decimal ValorIcmsST()
        {
            throw new SemICMSSTException();
        }

        public decimal PercRedBaseIcms()
        {
            throw new SemRedBaseIcmsException();
        }

        //public decimal ValorRedBaseIcms()
        //{
        //    throw new SemRedBaseIcmsException();
        //}

        public decimal PercRedBaseIcmsST()
        {
            throw new SemRedBaseIcmsSTException();
        }

        //public decimal ValorRedBaseIcmsST()
        //{
        //    throw new SemRedBaseIcmsSTException();
        //}
    }
}
