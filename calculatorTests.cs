using NUnit.Framework;
using System;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Add_TwoPositiveNumbers_ReturnsCorrectResult()
        {
            Assert.AreEqual(8, calculator.Add(3, 5));
            Assert.AreEqual(10, calculator.Add(5, 5));
            Assert.AreNotEqual(0, calculator.Add(5, 5));
        }

        [Test]
        public void Add_PositiveAndNegativeNumbers_ReturnsCorrectResult()
        {
            Assert.AreEqual(7, calculator.Add(10, -3));
            Assert.AreEqual(-7, calculator.Add(-4, -3));
            Assert.AreEqual(2, calculator.Add(-1, 3));
            Assert.AreNotEqual(7, calculator.Add(-1, 3));
        }

        [Test]
        public void Add_ZeroAndPositiveNumber_ReturnsCorrectResult()
        {
            Assert.AreEqual(7, calculator.Add(0, 7));
            Assert.AreEqual(0, calculator.Add(0, 0));
            Assert.AreEqual(6, calculator.Add(6, 0));
        }

        [Test]
        public void Subtract_TwoPositiveNumbers_ReturnsCorrectResult()
        {
            Assert.AreEqual(6, calculator.Subtract(10, 4));
            Assert.AreEqual(-4, calculator.Subtract(3, 7));
            Assert.AreEqual(0, calculator.Subtract(6, 6));
        }

        [Test]
        public void Subtract_NegativeAndPositiveNumbers_ReturnsCorrectResult()
        {
            Assert.AreEqual(-8, calculator.Subtract(-5, 3));
            Assert.AreEqual(6, calculator.Subtract(4, -2));
            Assert.AreEqual(1, calculator.Subtract(-8, -9));
            Assert.AreEqual(-2, calculator.Subtract(-4, -2));
        }

        [Test]
        public void Subtract_PositiveAndZero_ReturnsCorrectResult()
        {
            Assert.AreEqual(10, calculator.Subtract(10, 0));
            Assert.AreEqual(-5, calculator.Subtract(0, 5));
        }

        [Test]
        public void Subtract_NagativeAndZero_ReturnsCorrectResult()
        {
            Assert.AreEqual(-10, calculator.Subtract(-10, 0));
            Assert.AreEqual(60, calculator.Subtract(0, -60));
        }

        [Test]
        public void Multiply_TwoPositiveNumbers_ReturnsCorrectResult()
        {
            Assert.AreEqual(20, calculator.Multiply(4, 5));
            Assert.AreEqual(64, calculator.Multiply(8, 8));
        }

        [Test]
        public void Multiply_PositiveAndNegativeNumbers_ReturnsCorrectResult()
        {
            Assert.AreEqual(-18, calculator.Multiply(-3, 6));
            Assert.AreEqual(-40, calculator.Multiply(8, -5));
            Assert.AreEqual(36, calculator.Multiply(-6, -6));
        }

        [Test]
        public void Multiply_ZeroAndPositiveNumber_ReturnsZero()
        {
            Assert.AreEqual(0, calculator.Multiply(0, 7));
            Assert.AreEqual(0, calculator.Multiply(8, 0));
            Assert.AreEqual(0, calculator.Multiply(0, 0));
        }

        [Test]
        public void Divide_TwoPositiveNumbers_ReturnsCorrectResult()
        {
            Assert.AreEqual(5, calculator.Divide(10, 2));
            Assert.AreEqual(1, calculator.Divide(2, 2));
            Assert.AreEqual(0, calculator.Divide(5, 10));
        }

        [Test]
        public void Divide_DivideByZero_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => calculator.Divide(8, 0));
        }

        [Test]
        public void Divide_NegativeAndPositiveNumbers_ReturnsCorrectResult()
        {
            Assert.AreEqual(-5, calculator.Divide(-15, 3));
            Assert.AreEqual(-5, calculator.Divide(25, -5));
        }

        [Test]
        public void Square_PositiveNumber_ReturnsCorrectResult()
        {
            Assert.AreEqual(16, calculator.Square(4));
            Assert.AreEqual(25, calculator.Square(5));
        }

        [Test]
        public void Square_NegativeNumber_ReturnsCorrectResult()
        {
            Assert.AreEqual(16, calculator.Square(-4));
            Assert.AreEqual(144, calculator.Square(-12));
        }

        [Test]
        public void Square_Zero_ReturnsZero()
        {
            int result = calculator.Square(0);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void SquareRoot_PositiveNumber_ReturnsCorrectResult()
        {
            Assert.AreEqual(2, calculator.SquareRoot(4));
            Assert.AreEqual(5, calculator.SquareRoot(25));
        }

        [Test]
        public void SquareRoot_Zero_ReturnsZero()
        {
            double result = calculator.SquareRoot(0);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void SquareRoot_NegativeNumber_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => calculator.SquareRoot(-4));
        }
    }
}
