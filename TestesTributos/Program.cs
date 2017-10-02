using FiscalNET.Implementacoes.Icms;
using FiscalNET.Interfaces;
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
            IIcms icms202 = new Icms201_202_203(12, 18, 400, 1565, 35, 39, 8000, 0);

            decimal baseIcms = icms202.ValorIcms();

            decimal baseSt = icms202.BaseIcmsST();
            decimal valorSt = icms202.ValorIcmsST();
            
            Console.WriteLine($"Base ST: {baseSt.ToString("N2")}");
            Console.WriteLine($"Valor ST: {valorSt.ToString("N2")}");

            Console.ReadKey();
        }
    }
}

