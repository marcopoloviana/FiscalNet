using FiscalNet.Implementacoes.IcmsExceptions;
using FiscalNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNet.Implementacoes.Icms
{
    public class Icms70 : IIcms
    {
        private decimal AliqIcmsProprio { get; set; }
        private decimal AliqRedBcIcms { get; set; }
        private decimal AliqIcmsST { get; set; }
        private decimal AliqRedBcIcmsST { get; set; }
        private decimal Mva { get; set; }
        private decimal ValorIpi { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorProduto { get; set; }
        private decimal ValorSeguro { get; set; }

        public Icms70(decimal aliqIcmsProprio, decimal aliqRedBcIcms,
            decimal aliqIcmsST, decimal aliqRedBcIcmsST, decimal mva,
            decimal valorIpi, decimal despesasAcessorias,
            decimal valorFrete, decimal valorProduto,
            decimal valorSeguro)
        {
            this.PossuiRedBCIcmsProprio = true;
            this.PossuiRedBCIcmsST      = true;
            this.AliqIcmsProprio        = aliqIcmsProprio;
            this.AliqRedBcIcms          = aliqRedBcIcms;
            this.AliqIcmsST             = aliqIcmsST;
            this.AliqRedBcIcmsST        = aliqRedBcIcmsST;
            this.Mva                    = mva;
            this.ValorIpi               = 0;
            this.DespesasAcessorias     = despesasAcessorias;
            this.ValorFrete             = valorFrete;
            this.ValorProduto           = valorProduto;
            this.ValorSeguro            = valorSeguro;

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
                return this.PossuiRedBCIcmsProprio;
            }

            set
            {
                this.PossuiRedBCIcmsProprio = value;
            }
        }

        public bool PossuiRedBCIcmsST
        {
            get
            {
                return this.PossuiRedBCIcmsST;
            }

            set
            {
                this.PossuiRedBCIcmsST = value;
            }
        }

        public decimal ValorRedBaseIcms()
        {
            if (this.PossuiRedBCIcmsProprio)
                return new BaseReduzidaIcms(ValorIpi, DespesasAcessorias, ValorFrete, ValorProduto, ValorSeguro, AliqRedBcIcms).GerarBaseReduzidaIcms();
            else
               return this.BaseIcms();

        }

        public decimal BaseIcms()
        {
            return new BaseIcms(ValorIpi, DespesasAcessorias, ValorFrete, ValorProduto, ValorSeguro).GerarBaseIcms();
        }

        public decimal ValorIcms()
        {            
            if (this.PossuiRedBCIcmsProprio)
                return (AliqIcmsProprio / 100) * this.ValorRedBaseIcms();
            else
                return (AliqIcmsProprio / 100) * this.BaseIcms();
        }

        public decimal ValorRedBaseIcmsST()
        {
            if (this.PossuiRedBCIcmsProprio)
            {
                decimal vBaseIcmsST = new BaseIcmsST(ValorIpi, DespesasAcessorias, ValorFrete, ValorProduto, ValorSeguro, Mva).GerarBaseIcmsST();
                return vBaseIcmsST * (AliqRedBcIcmsST / 100);
            }
            else
                return this.BaseIcmsST();                
        }

        public decimal BaseIcmsST()
        {
            return new BaseIcmsST(ValorIpi, DespesasAcessorias, ValorFrete, ValorProduto, ValorSeguro, Mva).GerarBaseIcmsST();
        }

        public decimal ValorIcmsST()
        {
            if (this.PossuiRedBCIcmsST)                
                return ((this.ValorRedBaseIcmsST() * (AliqIcmsST / 100)) - this.ValorIcms());
            else
                return ((this.BaseIcmsST() * (AliqIcmsST / 100)) - this.ValorIcms());
        }

        public decimal PercRedBaseIcms()
        {
            return this.AliqRedBcIcms;
        }

        public decimal PercRedBaseIcmsST()
        {
            return this.AliqRedBcIcmsST;
        }        


    }
}



