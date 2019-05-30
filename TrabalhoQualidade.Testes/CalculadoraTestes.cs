using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrabalhoQualidade.Models;

namespace TrabalhoQualidade.Testes
{
    [TestClass]
    public class CalculadoraTestes
    {
        Calculadora calculadora = new Calculadora();

        [TestMethod]
        public void DeveConverterUmDecimalDeUmDigitoParaBinario()
        {
            var r = calculadora.DecimalParaBinario(4);
            Assert.AreEqual(100, r);
        }

        [TestMethod]
        public void DeveConverterUmDecimalDeDoisDigitosParaBinario()
        {
            var r = calculadora.DecimalParaBinario(10);
            Assert.AreEqual(1010, r);
        }

        [TestMethod]
        public void DeveConverterUmBinarioDeDoisDigitosParaDecimal()
        {
            var r = calculadora.BinarioParaDecimal(11);
            Assert.AreEqual(3, r);
        }

        [TestMethod]
        public void DeveConverterUmBinarioDeTresDigitosParaDecimal()
        {
            var r = calculadora.BinarioParaDecimal(100);
            Assert.AreEqual(4, r);
        }
    }
}
