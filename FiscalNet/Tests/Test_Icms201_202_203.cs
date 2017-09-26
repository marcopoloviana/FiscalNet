/*
using Fiscal.NET.Implementacoes.IcmsImpl;
using Fiscal.NET.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fiscal.NET.Tests
{
    [TestClass]
    public class Test_Icms201_202_203
    {
        [TestMethod]
        public void DEVE_CALCULAR_BASE_E_VALOR_ST()
        {
            Icms icms202 = new Icms201_202_203(12, 18, 400, 1565, 35, 39, 8000, 0);

            decimal baseSt = icms202.BaseIcmsST();
            decimal valorSt = icms202.ValorIcmsST();

            Assert.IsTrue(baseSt == 13900);
            Assert.IsTrue(valorSt == 1350);
        }
    }
}
*/