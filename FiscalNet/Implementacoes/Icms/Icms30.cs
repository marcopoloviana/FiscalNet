using FiscalNet.Implementacoes.IcmsExceptions;
using FiscalNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNet.Implementacoes.Icms
{
    public class Icms30 : IIcms
    {
        private decimal AliqIcmsProprio { get; set; }
        private decimal AliqIcmsST { get; set; }
        private decimal ValorIpi { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal Mva { get; set; }
        private decimal ValorProduto { get; set; }
        private decimal ValorSeguro { get; set; }

        public Icms30(decimal aliqIcmsProprio,
            decimal aliqIcmsST, decimal valorIpi, decimal despesasAcessorias,
            decimal valorFrete, decimal mva, decimal valorProduto,
            decimal valorSeguro)
        {
            this.AliqIcmsProprio    = aliqIcmsProprio;
            this.AliqIcmsST         = aliqIcmsST;
            this.ValorIpi           = 0;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorFrete         = valorFrete;
            this.Mva                = mva;
            this.ValorProduto       = valorProduto;
            this.ValorSeguro        = valorSeguro;
        }
        public bool PossuiIcmsProprio
        {
            get
            {
                return false;
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
                

        public decimal BaseIcmsST()
        {
            return new BaseIcmsST(ValorIpi, DespesasAcessorias, ValorFrete, ValorProduto, ValorSeguro, Mva).GerarBaseIcmsST();
        }

        public decimal ValorIcmsST()
        {
            return new ValorIcmsST(AliqIcmsProprio, AliqIcmsST, ValorIpi, DespesasAcessorias, ValorFrete, Mva, ValorProduto, ValorSeguro).GerarValorIcmsST();
        }

        public decimal BaseIcms()
        {
            throw new SemBasePropriaException();
        }

        public decimal ValorIcms()
        {
            throw new SemBasePropriaException();
        }

        public decimal PercRedBaseIcms()
        {
            throw new SemRedBaseIcmsException();
        }

        public decimal PercRedBaseIcmsST()
        {
            throw new SemRedBaseIcmsSTException();
        }                

        public decimal ValorRedBaseIcms()
        {
            throw new SemRedBaseIcmsSTException();
        }

        public decimal ValorRedBaseIcmsST()
        {
            throw new SemRedBaseIcmsSTException();
        }
    }
}
