/// <summary>
/// Mathlib.cs
/// 
/// Dominik Hofman (xhofma11)
/// Jana Veronika Moskvová (xmoskv01)
/// Tomas Skypala (xskypa03)
/// Erik Žák (xzaker00)
///
/// Implementation of Mathlib.version 0.1
/// Last update 2024-03-16
/// <summary>

using System;
using exeptions;

namespace Mathlib
{
    public class Operations
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Sub(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Mul(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Div(double num1, double num2)
        {
            if (num2 == 0.0)
            {
                throw new DivZeroException("Division by zero is not possible.");
            }
            return num1 / num2;
        }
        public double Mod(double num1, double num2)
        {
            return num1 % num2;
        }
        public double Pow(double num1, double num2)
        {
            if (num2 < 0 || num2 % 1 != 0)
            {
                throw new PowNaturalException( "Power have to be natural number.");
            }else if (num1 == 0 || num2 == 0)
            {
                return 1;
            }else
            {
                double j = num1;
                for (int i = 0; i < num2 - 1; i++)
                {
                    num1 = num1 * j;
                }
                return num1;
            }
        }
        public double Sqrt(double num1, double num2)
        {
            if (num2 < 0 || num2 % 1 != 0)
            {
                throw new SqrtNaturalExeption("Square root have to be natural number.");
            } else if (num1 < 0)
            {
                throw new SqrtNegExeption("Negative numbers cant be square rooted.");
            } else if (num2 == 0)
            {
                throw new SqrtbyZeroExeption("Infinity.");
            }
            return System.Math.Pow(num1, 1.0 / num2);
        }
        public double Faktorial(double num1)
        {
            if (num1 < 0)
            {
                throw new FactorialExeption("Negative number is not allowed in faktorial.");
            }else
            {
                double j = 1;
                for (int i = 2; i <= num1; i++)
                {
                    j *= i;
                }
                return j;
            }
        }
    }
}