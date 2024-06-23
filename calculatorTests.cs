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
        public void Add_TwoPositiveNumbers()
        {
            Assert.AreEqual(8, calculator.Add(3, 5));
            Assert.AreEqual(10, calculator.Add(5, 5));
            Assert.AreNotEqual(0, calculator.Add(5, 5));
        }

        [Test]
        public void Add_PositiveAndNegativeNumbers()
        {
            Assert.AreEqual(7, calculator.Add(10, -3));
            Assert.AreEqual(-7, calculator.Add(-4, -3));
            Assert.AreEqual(2, calculator.Add(-1, 3));
            Assert.AreNotEqual(7, calculator.Add(-1, 3));
        }

        [Test]
        public void Add_ZeroAndPositiveNumber()
        {
            Assert.AreEqual(7, calculator.Add(0, 7));
            Assert.AreEqual(0, calculator.Add(0, 0));
            Assert.AreEqual(6, calculator.Add(6, 0));
        }

        [Test]
        public void Add_LargeNumbers()
        {
            Assert.AreEqual(1000000000, calculator.Add(500000000, 500000000));
            Assert.AreEqual(-2000000000, calculator.Add(-1000000000, -1000000000));
        }

        [Test]
        public void Subtract_TwoPositiveNumbers()
        {
            Assert.AreEqual(6, calculator.Subtract(10, 4));
            Assert.AreEqual(-4, calculator.Subtract(3, 7));
            Assert.AreEqual(0, calculator.Subtract(6, 6));
        }

        [Test]
        public void Subtract_NegativeAndPositiveNumbers()
        {
            Assert.AreEqual(-8, calculator.Subtract(-5, 3));
            Assert.AreEqual(6, calculator.Subtract(4, -2));
            Assert.AreEqual(1, calculator.Subtract(-8, -9));
            Assert.AreEqual(-2, calculator.Subtract(-4, -2));
        }

        [Test]
        public void Subtract_PositiveAndZero()
        {
            Assert.AreEqual(10, calculator.Subtract(10, 0));
            Assert.AreEqual(-5, calculator.Subtract(0, 5));
        }

        [Test]
        public void Subtract_NagativeAndZero()
        {
            Assert.AreEqual(-10, calculator.Subtract(-10, 0));
            Assert.AreEqual(60, calculator.Subtract(0, -60));
        }

        [Test]
        public void Subtract_LargeNumbers()
        {
            Assert.AreEqual(1000000000, calculator.Subtract(1500000000, 500000000));
            Assert.AreEqual(-2000000000, calculator.Subtract(-1000000000, 1000000000));
        }

        [Test]
        public void Multiply_TwoPositiveNumbers()
        {
            Assert.AreEqual(20, calculator.Multiply(4, 5));
            Assert.AreEqual(64, calculator.Multiply(8, 8));
        }

        [Test]
        public void Multiply_PositiveAndNegativeNumbers()
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
        public void Multiply_LargeNumbers()
        {
            Assert.AreEqual(1000000000, calculator.Multiply(500000, 2000));
            Assert.AreEqual(-2000000000, calculator.Multiply(-1000000, 2000));
        }

        [Test]
        public void Divide_TwoPositiveNumbers()
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
        public void Divide_NegativeAndPositiveNumbers()
        {
            Assert.AreEqual(-5, calculator.Divide(-15, 3));
            Assert.AreEqual(-5, calculator.Divide(25, -5));
        }

        [Test]
        public void Divide_LargeNumbers()
        {
            Assert.AreEqual(1000, calculator.Divide(1000000, 1000));
            Assert.AreEqual(-500, calculator.Divide(1000, -2));
        }

        [Test]
        public void Square_PositiveNumber()
        {
            Assert.AreEqual(16, calculator.Square(4));
            Assert.AreEqual(25, calculator.Square(5));
        }

        [Test]
        public void Square_NegativeNumber()
        {
            Assert.AreEqual(16, calculator.Square(-4));
            Assert.AreEqual(144, calculator.Square(-12));
        }

        [Test]
        public void Square_Zero_ReturnsZero()
        {
            Assert.AreEqual(0, calculator.Square(0));
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
            
            Assert.AreEqual(0, calculator.SquareRoot(0));
        }

        [Test]
        public void SquareRoot_NegativeNumber_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => calculator.SquareRoot(-4));
        }

        [Test]
        public void SquareRoot_LargeNumbers_ReturnsCorrectResult()
        {
            Assert.AreEqual(1000, calculator.SquareRoot(1000000));
            Assert.AreEqual(50, calculator.SquareRoot(2500));
        }
    }
}
