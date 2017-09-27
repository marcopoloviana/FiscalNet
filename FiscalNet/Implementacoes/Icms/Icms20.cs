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
        private decimal AliqIcms { get; set; }
        private decimal AliqRedBcIcms { get; set; }
        private decimal ValorIpi { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorProduto { get; set; }
        private decimal ValorSeguro { get; set; }

        public Icms20(decimal aliqIcms, decimal aliqRedBcIcms,
            decimal valorIpi, decimal despesasAcessorias,
            decimal valorFrete, decimal valorProduto,
            decimal valorSeguro)
        {
            this.AliqIcms = aliqIcms;
            this.AliqRedBcIcms = aliqRedBcIcms; 
            this.ValorIpi = valorIpi;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorFrete = valorFrete;
            this.ValorProduto = valorProduto;
            this.ValorSeguro = valorSeguro;
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
            /*
            * Base do ICMS Inter = (Valor do produto +
            *  Frete +
            *   Seguro + 
            *   Outras Despesas Acessórias – Descontos) * (AliqRedBcIcms / 100)
            * */

            decimal resultado = (ValorProduto +
                ValorFrete +
                ValorSeguro +
                DespesasAcessorias) * (AliqRedBcIcms / 100);
            return resultado;
        }

        public decimal ValorIcms()
        {
            decimal baseIcmsProprio = BaseIcms();
            decimal resultado = (AliqIcms / 100 * baseIcmsProprio);
            return resultado;
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

        public decimal ValorRedBaseIcms()
        {
            throw new NotImplementedException();
        }

        public decimal ValorRedBaseIcmsST()
        {
            throw new NotImplementedException();
        }
    }
}
