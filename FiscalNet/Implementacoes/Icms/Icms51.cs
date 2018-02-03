using FiscalNet.Implementacoes.IcmsExceptions;
using FiscalNet.Interfaces;

namespace FiscalNet.Implementacoes.Icms
{
    public class Icms51 : IIcms
    {
        private decimal ValorProduto { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorSeguro { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorIpi { get; set; }
        private decimal ValorDesconto { get; set; }
        private decimal AliqIcmsProprio { get; set; }
        private decimal AliqDifIcms { get; set; }

        private BaseIcms BaseCalculo { get; set; }

        public Icms51(decimal valorProduto,
            decimal valorFrete,
            decimal valorSeguro,
            decimal despesasAcessorias,
            decimal valorIpi,
            decimal valorDesconto,
            decimal aliqIcmsProprio,
            decimal aliqDifIcms)
        {
            this.ValorProduto       = valorProduto;
            this.ValorFrete         = valorFrete;
            this.ValorSeguro        = valorSeguro;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorIpi           = valorIpi;
            this.ValorDesconto      = valorDesconto;
            this.AliqIcmsProprio    = aliqIcmsProprio;
            this.AliqDifIcms        = aliqDifIcms;
            this.BaseCalculo        = new BaseIcms(ValorProduto, ValorFrete, ValorSeguro, DespesasAcessorias, ValorIpi, ValorDesconto);
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
            return BaseCalculo.GerarBaseIcms();
        }

        public decimal ValorIcms()
        {
            return new ValorIcms(BaseIcms(), AliqIcmsProprio).GerarValorIcms();            
        }

        public decimal ValorIcmsDiferido()
        {
            return (ValorIcms() - ((ValorIcms() * (AliqDifIcms / 100))));            
        }

        public decimal BaseIcmsST()
        {
            throw new SemICMSSTException();
        }

        public decimal ValorIcmsST()
        {
            throw new SemICMSSTException();
        }

    }
}
