using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrabalhoQualidade.Models;

namespace TrabalhoQualidade.Testes
{
    [TestClass]
    public class DecimalParaBinarioTestes
    {
        Calculadora calculadora = new Calculadora();

        [TestMethod]
        public void DeveConverterONumeroZero()
        {
            var r = calculadora.DecimalParaBinario(0);
            Assert.AreEqual(0, r);
        }

        [TestMethod]
        public void DeveConverterUmDecimalDeUmDigito()
        {
            var r = calculadora.DecimalParaBinario(4);
            Assert.AreEqual(10, r);
        }

        [TestMethod]
        public void DeveConverterUmDecimalDeDoisDigitos()
        {
            var r = calculadora.DecimalParaBinario(10);
            Assert.AreEqual(1010, r);
        }

        [TestMethod]
        public void ConverterNumeroNegativo()
        {
            var r = calculadora.DecimalParaBinario(-1);
            Assert.AreEqual(0, r);
            Assert.AreEqual(1, calculadora.Notificacoes.Count);
        }
    }
}
