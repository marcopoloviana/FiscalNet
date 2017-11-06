using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNet.Implementacoes.Icms
{
    public class BaseReduzidaIcms
    {
        private decimal ValorIpi { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorProduto { get; set; }
        private decimal ValorSeguro { get; set; }
        private decimal AliqBcRedIcms { get; set; }

        public BaseReduzidaIcms(decimal valorIpi,
            decimal despesasAcessorias,
            decimal valorFrete, decimal valorProduto,
            decimal valorSeguro, decimal aliqBcRedIcms)
        {
            this.ValorIpi           = valorIpi;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorFrete         = valorFrete;
            this.ValorProduto       = valorProduto;
            this.ValorSeguro        = valorSeguro;
            this.AliqBcRedIcms      = aliqBcRedIcms;
        }

        public decimal GerarBaseReduzidaIcms()
        {
                /*
                * Base do ICMS Inter = (Valor do produto +
                *  Frete +
                *   Seguro + 
                *   Outras Despesas Acessórias – Descontos) 
                *
                * Base Reduzida = Base do ICMS Inter - (Base doicms inter * (Aliq. Reducao / 100))
                */

                decimal BaseNormal = (ValorProduto +
                    ValorFrete +
                    ValorSeguro +
                    DespesasAcessorias);

                decimal BaseReduzidaIcms = BaseNormal - (BaseNormal * (AliqBcRedIcms / 100));

                return BaseReduzidaIcms;
            }            
            
        }

    }
}
