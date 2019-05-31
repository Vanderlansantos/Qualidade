using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrabalhoQualidade.Models;

namespace TrabalhoQualidade.Testes
{
    [TestClass]
    public class BinarioParaDecimalTestes
    {
        Calculadora calculadora = new Calculadora();

        [TestMethod]
        public void DeveConverterUmBinarioDeDoisDigitos()
        {
            var r = calculadora.BinarioParaDecimal(11);
            Assert.AreEqual(3, r);
        }

        [TestMethod]
        public void DeveConverterUmBinarioDeTresDigitos()
        {
            var r = calculadora.BinarioParaDecimal(100);
            Assert.AreEqual(4, r);
        }

        [TestMethod]
        public void ConverterNumeroNaoBinario()
        {
            var r = calculadora.BinarioParaDecimal(7);
            Assert.AreEqual(0, r);
            Assert.AreEqual(1, calculadora.Notificacoes.Count);
        }
    }
}
