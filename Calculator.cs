using System;

   public class Calculator
    {

        // Addition
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Subtraction
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        // Multiplication
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        // Division
        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }
            return a / b;
        }

        // Square of a number
        public int Square(int a)
        {
            return a * a;
        }


        // SquareRoot of a number
        public double SquareRoot(int a) {
        if (a < 0) {
            throw new ArgumentException("Cannot square root.");
        }
        
        if (a == 0 || a == 1) {
            return a; 
        }

        return Math.Sqrt(a);
    }
    }