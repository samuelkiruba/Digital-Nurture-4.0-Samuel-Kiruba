using NUnit.Framework;
using CalcLibrary;
using System;

namespace CalcLibrary
{
    [TestFixture]
    public class CalculatorTests
    {
        SimpleCalculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new SimpleCalculator();
        }

        [Test]
        [TestCase(2, 3, 5)]
        [TestCase(-1, -1, -2)]
        public void Addition_ShouldReturnCorrectResult(double a, double b, double expected)
        {
            Assert.That(calc.Addition(a, b), Is.EqualTo(expected));
        }

        [Test]
        public void Division_ByZero_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => calc.Division(5, 0));
        }
    }
}
