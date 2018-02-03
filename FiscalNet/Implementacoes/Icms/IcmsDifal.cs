using FiscalNet.Interfaces;
using System;

namespace FiscalNet.Implementacoes.Icms
{
    public class IcmsDifal : IIcmsDifal
    {
        private decimal ValorProduto { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorSeguro { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorIpi { get; set; }
        private decimal ValorDesconto { get; set; }
        private decimal AliqIcmsProprio { get; set; }
        private decimal AliqIcmsInternoDestino { get; set; }
        private decimal Fcp { get; set; }
        private int Partilha { get;  set; }

        private BaseIcms BaseCalculo { get; set; }

        public IcmsDifal(decimal valorProduto,
            decimal valorFrete,
            decimal valorSeguro,
            decimal despesasAcessorias,
            decimal valorIpi,
            decimal valorDesconto, 
            decimal aliqIcmsProprio,
            decimal aliqIcmsInternoDestino,
            decimal fcp)
        {
            this.ValorProduto           = valorProduto;
            this.ValorFrete             = valorFrete;
            this.ValorSeguro            = valorSeguro;
            this.DespesasAcessorias     = despesasAcessorias;
            this.ValorIpi               = valorIpi;
            this.ValorDesconto          = valorDesconto;
            this.AliqIcmsProprio        = aliqIcmsProprio;
            this.AliqIcmsInternoDestino = aliqIcmsInternoDestino;
            this.Fcp                    = fcp;
            this.BaseCalculo            = new BaseIcms(ValorProduto, ValorFrete, ValorSeguro, DespesasAcessorias, ValorIpi, ValorDesconto);

            this.Partilha = 0;

            switch (DateTime.Now.Year)
            {
                case 2016:
                    Partilha = 40;
                    break;
                case 2017:
                    Partilha = 60;
                    break;
                case 2018:
                    Partilha = 80;
                    break;
                default:
                    Partilha = 100;
                    break;
            }
        }

        public decimal BaseIcms()
        {
            return BaseCalculo.GerarBaseIcms();
        }

        public decimal ValorFcpDestino()
        {
            decimal bcIcms = BaseIcms();

            return (Fcp / 100 * bcIcms);
        }

        public decimal ValorDifal()
        {
            return BaseIcms() * ((AliqIcmsInternoDestino - AliqIcmsProprio) / 100);
        }

        public decimal ValorIcmsDestino()
        {            
            return (ValorDifal() * (Partilha / 100));
        }

        public decimal ValorIcmsRemetente()
        {
            decimal difal = BaseIcms() * ((AliqIcmsInternoDestino - AliqIcmsProprio) / 100);           

            return (difal * ((100 - Partilha) / 100));
        }
    }
}
