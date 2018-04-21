using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FizzBuzz;

namespace FizzBuzzUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private List<string> _results;

        [TestInitialize]
        public void Init()
        {
            var generator = new FizzBuzzGenerator();
            _results = generator.Generate();
        }

        [TestMethod]
        public void Element1()
        {
            Assert.AreEqual("1", _results[0]);
        }

        [TestMethod]
        public void Element2()
        {
            Assert.AreEqual("2", _results[1]);
        }

        [TestMethod]
        public void Element3()
        {
            Assert.AreEqual("Fizz", _results[2]);
        }

        [TestMethod]
        public void Element4()
        {
            Assert.AreEqual("4", _results[3]);
        }

        [TestMethod]
        public void Element5()
        {
            Assert.AreEqual("Buzz", _results[4]);
        }

        [TestMethod]
        public void Element6()
        {
            Assert.AreEqual("Fizz", _results[5]);
        }

        [TestMethod]
        public void Element7()
        {
            Assert.AreEqual("7", _results[6]);
        }

        [TestMethod]
        public void Element15()
        {
            Assert.AreEqual("FizzBuzz", _results[14]);
        }



    }
}
