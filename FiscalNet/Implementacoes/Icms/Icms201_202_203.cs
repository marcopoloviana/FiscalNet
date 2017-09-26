using FiscalNET.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNET.Implementacoes.IcmsImpl
{
    public class Icms201_202_203 : IIcms
    {
        private decimal AliqInterest { get; set; }
        private decimal AliqInterna { get; set; }
        private decimal ValorIpi { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal MVA { get; set; }
        private decimal ValorProduto { get; set; }
        private decimal ValorSeguro { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aliqInterest"></param>
        /// <param name="aliqInterna"></param>
        /// <param name="valorIpi"></param>
        /// <param name="despesasAcessorias"></param>
        /// <param name="valorFrete"></param>
        /// <param name="mva"></param>
        /// <param name="valorProduto"> OBS: Já deve vir com desconto/acrescimo </param>
        /// <param name="valorSeguro"></param>
        public Icms201_202_203(decimal aliqInterest,
            decimal aliqInterna, decimal valorIpi, decimal despesasAcessorias,
            decimal valorFrete, decimal mva, decimal valorProduto,
            decimal valorSeguro)
        {
            this.AliqInterest = aliqInterest;
            this.AliqInterna = aliqInterna;
            this.ValorIpi = valorIpi;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorFrete = valorFrete;
            this.MVA = mva;
            this.ValorProduto = valorProduto;
            this.ValorSeguro = valorSeguro;
        }

        private decimal BaseICMSProprio()
        {
            /*
             * Base do ICMS Inter = (Valor do produto +
             *  Frete +
             *   Seguro + 
             *   Outras Despesas Acessórias – Descontos)
             * */

            decimal resultado = (ValorProduto +
                ValorFrete +
                ValorSeguro +
                DespesasAcessorias);
            return resultado;
        }

        private decimal ValorICMSProprio()
        {
            decimal baseIcmsProprio = BaseICMSProprio();
            decimal resultado = (AliqInterest / 100 * baseIcmsProprio);
            return resultado;
        }

        public decimal BaseIcmsST()
        {
            /*
             * (Valor do produto +
             *  Valor do IPI +
             *  Frete + 
             *  Seguro +
             *  Outras Despesas Acessórias – Descontos) * (1+(%MVA / 100))
             * */

            decimal resultado = ((ValorProduto +
                ValorIpi +
                ValorFrete +
                ValorSeguro +
                DespesasAcessorias) * (1 + (MVA / 100)));

            return resultado;
        }

        public decimal ValorIcmsST()
        {
            /*
             * (Base do ICMS ST * (Alíquota do ICMS Intra / 100)) – Valor do ICMS Inter
             * */

            decimal icmsProprio = ValorICMSProprio();
            decimal resultado = (BaseIcmsST() * (AliqInterna / 100)) - icmsProprio;
            return resultado;
        }

        public decimal BaseIcms()
        {
            throw new Exception("Este CSOSN não possui base própria de ICMS.");
        }

        public decimal ValorIcms()
        {
            throw new Exception("Este CSOSN não possui ICMS próprio.");
        }
    }
}
