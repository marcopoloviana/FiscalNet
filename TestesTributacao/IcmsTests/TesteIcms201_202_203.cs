using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiscalNet.Implementacoes.Icms;
using FiscalNet.Interfaces;

namespace TestesTributacao.IcmsTests
{
    [TestClass]
    public class TesteIcms201_202_203
    {
        [TestMethod]
        public void TesteCSOSN201_202_203()
        {
            IIcms icms202 = new Icms201_202_203(0, 0, 0, 0, 0, 0, 0, 0, 0);

            Assert.AreEqual(13900, icms202.BaseIcmsST());
            Assert.AreEqual(1350, icms202.ValorIcmsST());            
        }
    }
}
