/*
 * O CST 70 PODE CALCULAR REDUÇÃO EM UMA DAS BASES DE ICMS
 * OU NAS DUAS
 * 
 */

using FiscalNet.Interfaces;

namespace FiscalNet.Implementacoes.Icms
{
    public class Icms70 : IIcms
    {
        private decimal ValorProduto { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorSeguro { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorIpi { get; set; }
        private decimal ValorDesconto { get; set; }
        private decimal AliqIcmsProprio { get; set; }
        private decimal AliqRedBcIcms { get; set; }
        private decimal AliqIcmsST { get; set; }
        private decimal AliqRedBcIcmsST { get; set; }
        private decimal Mva { get; set; }

        private BaseIcms BaseCalculo { get; set; }
        private BaseReduzidaIcms BaseCalculoReduzida { get; set; }

        public Icms70(decimal valorProduto,
            decimal valorFrete,
            decimal valorSeguro,
            decimal despesasAcessorias,
            decimal valorIpi,
            decimal valorDesconto,
            decimal aliqIcmsProprio,
            decimal aliqRedBcIcms,
            decimal aliqIcmsST, 
            decimal aliqRedBcIcmsST,
            decimal mva)
        {
            this.ValorProduto           = valorProduto;
            this.ValorFrete             = valorFrete;
            this.ValorSeguro            = valorSeguro;
            this.DespesasAcessorias     = despesasAcessorias;
            this.ValorIpi               = valorIpi;
            this.ValorDesconto          = valorDesconto;
            this.AliqIcmsProprio        = aliqIcmsProprio;
            this.AliqRedBcIcms          = aliqRedBcIcms;
            this.AliqIcmsST             = aliqIcmsST;
            this.AliqRedBcIcmsST        = aliqRedBcIcmsST;
            this.Mva                    = mva;
            this.BaseCalculo            = new BaseIcms(ValorProduto, ValorFrete, ValorSeguro, DespesasAcessorias, ValorIpi, ValorDesconto);
            this.BaseCalculoReduzida    = new BaseReduzidaIcms(ValorProduto, ValorFrete, ValorSeguro, DespesasAcessorias, ValorIpi, ValorDesconto,AliqRedBcIcms);
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
                return (AliqRedBcIcms > 0);
            }
        }

        public bool PossuiRedBCIcmsST
        {
            get
            {
                return (AliqRedBcIcmsST > 0);
            }
        }


        public decimal BaseIcms()
        {
            if (this.PossuiRedBCIcmsProprio)
                return BaseCalculoReduzida.GerarBaseReduzidaIcms();
            else
                return BaseCalculo.GerarBaseIcms();
        }

        public decimal ValorIcms()
        {
                return new ValorIcms(BaseIcms(), AliqIcmsProprio).GerarValorIcms();
        }

        public decimal BaseIcmsST()
        {
            if (this.PossuiRedBCIcmsST)
            {
                return new BaseReduzidaIcmsST(ValorProduto,ValorFrete,ValorSeguro,DespesasAcessorias,ValorIpi,ValorDesconto,AliqRedBcIcmsST).GerarBaseReduzidaIcmsST();
            }
            else
                return new BaseIcmsST(BaseIcms(), Mva).GerarBaseIcmsST();
        }

        public decimal ValorIcmsST()
        {
                return ((this.BaseIcmsST() * (AliqIcmsST / 100)) - this.ValorIcms());
        }        
    }
}



