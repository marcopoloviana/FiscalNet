using FiscalNet.Implementacoes.Icms;
using FiscalNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesTributos
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseValorST_201_202_203();
        }

        private static void BaseValorST_201_202_203()
        {
            IIcms icms51 = new Icms51(0, 0, 0, 0, 0, 0, 0, 0);

            //decimal valorOperacao = (icms51 as Icms51).ValorOperacao();

            decimal valorIcmsDif, valorIcmsOp; 

            //decimal baseIcms = icms51.ValorIcms(out valorIcmsOp, out valorIcmsDif);

            decimal baseSt = icms51.BaseIcmsST();
            decimal valorSt = icms51.ValorIcmsST();

            Console.WriteLine($"Base ST: {baseSt.ToString("N2")}");
            Console.WriteLine($"Valor ST: {valorSt.ToString("N2")}");

            Console.ReadKey();
        }
    }
}

