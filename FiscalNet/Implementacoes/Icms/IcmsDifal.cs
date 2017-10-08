using FiscalNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNet.Implementacoes.Icms
{
    public class IcmsDifal : IIcmsDifal
    {
        private decimal AliqIcmsProprio { get; set; }
        private decimal AliqIcmsInternoDestino { get; set; }
        private decimal Fcp { get; set; }
        private decimal ValorIpi { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorProduto { get; set; }
        private decimal ValorSeguro { get; set; }
        private int Partilha { get;  set; }

        public IcmsDifal(decimal aliqIcmsProprio,
            decimal aliqIcmsInternoDestino,
            decimal fcp,
            decimal valorIpi, decimal despesasAcessorias,
            decimal valorFrete, decimal valorProduto,
            decimal valorSeguro)
        {
            this.AliqIcmsProprio        = aliqIcmsProprio;
            this.AliqIcmsInternoDestino = aliqIcmsInternoDestino;
            this.Fcp                    = fcp;
            this.ValorIpi               = valorIpi;
            this.DespesasAcessorias     = despesasAcessorias;
            this.ValorFrete             = valorFrete;
            this.ValorProduto           = valorProduto;
            this.ValorSeguro            = valorSeguro;

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
            return new BaseIcms(ValorIpi, DespesasAcessorias, ValorFrete, ValorProduto, ValorSeguro).GerarBaseIcms();
        }

        public decimal ValorFcpDestino()
        {
            decimal bcIcms = this.BaseIcms();

            return (Fcp / 100 * bcIcms);
        }

        public decimal ValorDifal()
        {
            return this.BaseIcms() * ((AliqIcmsInternoDestino - AliqIcmsProprio) / 100);
        }

        public decimal ValorIcmsDestino()
        {            

            return (this.ValorDifal() * (this.Partilha / 100));

        }

        public decimal ValorIcmsRemetente()
        {
            decimal difal = this.BaseIcms() * ((AliqIcmsInternoDestino - AliqIcmsProprio) / 100);           

            return (difal * ((100 - Partilha) / 100));
        }
    }
}
