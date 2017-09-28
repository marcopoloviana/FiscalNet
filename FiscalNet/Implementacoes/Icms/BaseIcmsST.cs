using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNet.Implementacoes.Icms
{
    public class BaseIcmsST
    {
        private decimal ValorIpi { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal MVA { get; set; }
        private decimal ValorProduto { get; set; }
        private decimal ValorSeguro { get; set; }

        public BaseIcmsST(decimal valorIpi, decimal despesasAcessorias,
            decimal valorFrete, decimal mva, decimal valorProduto,
            decimal valorSeguro)
        {
            this.ValorIpi           = valorIpi;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorFrete         = valorFrete;
            this.MVA                = mva;
            this.ValorProduto       = valorProduto;
            this.ValorSeguro        = valorSeguro;
        }

        public decimal GerarBaseIcmsST()
        {
            /*
           * (Valor do produto +
           *  Valor do IPI +
           *  Frete + 
           *  Seguro +
           *  Outras Despesas Acessórias – Descontos) * (1+(%MVA / 100))
           * */

            decimal BaseIcmsST = ((ValorProduto +
                ValorIpi +
                ValorFrete +
                ValorSeguro +
                DespesasAcessorias) * (1 + (MVA / 100)));

            return BaseIcmsST;
        }
    }
}
