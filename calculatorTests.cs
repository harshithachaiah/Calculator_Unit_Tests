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

        // Addition Valid results
        [Test]
        [TestCase(2, 3, 5)]
        [TestCase(6, 4, 10)]
        [TestCase(7, 5, 12)]
        public void Add_TwoPositiveNumbers(int a, int b, int expected)
        {
            Assert.AreEqual(expected, calculator.Add(a, b));
            Assert.AreNotEqual(0, calculator.Add(5, 5));
        }

        [Test]
        [TestCase(10, -3, 7)]
        [TestCase(-4, -3 ,-7)]
        [TestCase(-1, -3, -4)]
        [TestCase(-1, 6, 5)]
        public void Add_PositiveAndNegativeNumbers(int a, int b, int expected)
        {
            Assert.AreEqual(expected, calculator.Add(a, b));
            Assert.AreNotEqual(7, calculator.Add(-1, 3));
        }

        [Test]
        [TestCase(0, 7, 7)]
        [TestCase(0, 0 ,0)]
        [TestCase(6, 0, 6)]
        public void Add_ZeroAndPositiveNumber(int a, int b, int expected)
        {
            Assert.AreEqual(expected, calculator.Add(a, b));
            
        }

        [Test]
        [TestCase(500000000, 500000000 ,1000000000)]
        [TestCase(-1000000000, -1000000000, -2000000000)]
        public void Add_LargeNumbers(int a, int b, int expected)
        {
            Assert.AreEqual(expected, calculator.Add(a, b));
        }

        // Substraction Valid results
        [Test]
        [TestCase(10, 4, 6)]
        [TestCase(3, 7,-4)]
        [TestCase(6, 6, 0)]
        public void Subtract_TwoPositiveNumbers(int a, int b, int expected)
        {
            Assert.AreEqual(expected, calculator.Subtract(a, b));
            
        }

        [Test]
        [TestCase(-5, 3, -8)]
        [TestCase(4, -2, 6)]
        [TestCase(-8, -9, 1)]
        [TestCase(-4, -2, -2)]
        public void Subtract_NegativeAndPositiveNumbers(int a, int b, int expected)
        {
            Assert.AreEqual(expected, calculator.Subtract(a, b));
        
        }

        [Test]
        [TestCase(10, 0, 10)]
        [TestCase(0, 5, -5)]
        public void Subtract_PositiveAndZero(int a, int b, int expected)
        {
            Assert.AreEqual(expected, calculator.Subtract(a, b));
        }

        [Test]
        [TestCase(-10, 0, -10)]
        [TestCase(0, 60, -60)]
        public void Subtract_NagativeAndZero(int a, int b, int expected)
        {
            Assert.AreEqual(expected, calculator.Subtract(a, b));
            
        }

        [Test]
        [TestCase(1500000000, 500000000, 1000000000)]
        [TestCase(-1000000000, 1000000000, -2000000000)]
        public void Subtract_LargeNumbers(int a, int b, int expected)
        {
            Assert.AreEqual(expected, calculator.Subtract(a, b));
            
        }

        // Multiplication Valid results
        [Test]
        [TestCase(4, 5, 20)]
        [TestCase(8, 8, 64)]
        public void Multiply_TwoPositiveNumbers(int a, int b, int expected)
        {
            Assert.AreEqual(expected, calculator.Multiply(a, b));
        
        }

        [Test]
        [TestCase(-3, 6, -18)]
        [TestCase(8, -5, -40)]
        [TestCase(-6, -6, 36)]
        public void Multiply_PositiveAndNegativeNumbers(int a, int b, int expected)
        {
            Assert.AreEqual(expected, calculator.Multiply(a, b));
        }

        [Test]
        [TestCase(0, 7, 0)]
        [TestCase(8, 0, 0)]
        [TestCase(0, 0, 0)]
        public void Multiply_ZeroAndPositiveNumber(int a, int b, int expected)
        {
           Assert.AreEqual(expected, calculator.Multiply(a, b));
        }

        [Test]
        [TestCase(500000, 2000, 1000000000)]
        [TestCase(-1000000, 2000, -2000000000)]
        public void Multiply_LargeNumbers(int a, int b, int expected)
        {
            Assert.AreEqual(expected, calculator.Multiply(a, b));
        }


        // Division Valid results
        [Test]
        [TestCase(10, 2, 5)]
        [TestCase(2, 2, 1)]
        [TestCase(5, 10, 0)]
        public void Divide_TwoPositiveNumbers(int a, int b, int expected)
        {
            Assert.AreEqual(expected, calculator.Divide(a, b));
            
        }

        [Test]
        public void Divide_DivideByZero_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => calculator.Divide(8, 0));
        }

        [Test]
        [TestCase(-15, 3, -5)]
        [TestCase(25, -5, -5)]
        public void Divide_NegativeAndPositiveNumbers(int a, int b, int expected)
        {
            Assert.AreEqual(expected, calculator.Divide(a, b));
            
        }

        [Test]
        [TestCase(1000000, 1000, 1000)]
        [TestCase(1000, -2, -500)]
        public void Divide_LargeNumbers(int a, int b, int expected)
        {
            Assert.AreEqual(expected, calculator.Divide(a, b));
        }

        // Square of an number
        [Test]
        [TestCase(4, 16)]
        [TestCase(5, 25)]
        public void Square_PositiveNumber(int a, int expected)
        {
            
            Assert.AreEqual(expected, calculator.Square(a));
        }

        [Test]
        [TestCase(-8, 64)]
        [TestCase(-12, 144)]
        public void Square_NegativeNumber(int a, int expected)
        {
            Assert.AreEqual(expected, calculator.Square(a));
          
        }

        [Test]
        public void Square_Zero()
        {
            Assert.AreEqual(0, calculator.Square(0));
        }

        
        //  Square Root of an number
        [Test]
        [TestCase(4, 2)]
        [TestCase(25, 5)]
        public void SquareRoot_PositiveNumber(int a, int expected)
        {
            
            Assert.AreEqual(expected, calculator.SquareRoot(a));
        }

        [Test]
        public void SquareRoot_Zero()
        {
            
            Assert.AreEqual(0, calculator.SquareRoot(0));
        }

        [Test]
        public void SquareRoot_NegativeNumber_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => calculator.SquareRoot(-4));
        }

        [Test]
        [TestCase(1000000, 1000)]
        [TestCase(2500, 50)]
        public void SquareRoot_LargeNumbers(int a, int expected)
        {
            Assert.AreEqual(expected, calculator.SquareRoot(a));
            
        }
    }
}
