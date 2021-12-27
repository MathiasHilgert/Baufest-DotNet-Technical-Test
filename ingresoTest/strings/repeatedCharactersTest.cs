using Ingreso.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IngresoTest.Strings
{
    [TestClass]
    public class RepeatedCharactersTest
    {
        private RepeatedCharacters repeatedCharacters = new RepeatedCharacters();

        [TestMethod]
        public void IsValidSimple()
        {
            String input = "a3o1oa3";
            Assert.IsTrue(this.repeatedCharacters.IsValid(input));
            Assert.IsTrue(this.repeatedCharacters.IsValid("aa3311oo"));
        }

        [TestMethod]
        public void isValidWithSpaces()
        {
            String input = " ellemmeennttaall  mmaattssssnn";
            Assert.IsTrue(this.repeatedCharacters.IsValid(input));
            Assert.IsFalse(this.repeatedCharacters.IsValid(" eelleemmeennttaall  mmii  qquueerriiddoo  wwaattssoonn"));
        }

        [TestMethod]
        public void isValidWithExtraChar()
        {
            String input = "aabbccc";
            Assert.IsTrue(this.repeatedCharacters.IsValid(input));
            Assert.IsFalse(this.repeatedCharacters.IsValid("aaabbc"));
        }
    }
}
