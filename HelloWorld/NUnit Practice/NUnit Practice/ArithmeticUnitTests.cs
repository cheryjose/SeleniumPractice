using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;



namespace NUnit_Practice
{
    [TestFixture]
    public class ArithmeticUnitTests
    {
        private Arithmetic arithmtic;
        [TestFixtureSetUp]
        public void Setup()
        {
            arithmtic = new Arithmetic();
        }
        [TestFixtureTearDown]
        public void TearDown()
        {
            arithmtic = null;
        }
        [Test]
        public void TestAdd()
        {
            int result = arithmtic.sum(5, 6);
            Assert.AreEqual(11, result);
        }
        [Test]
        public void TestSub()
        {
            int result = arithmtic.sub(8, 4);
            Assert.AreEqual(4, result);
        }

    }
   
}
