/// <summary>
/// Mathlib.cs
/// 
/// Tomas Skypala (xskypa03)
///
/// Implementation of Mathlib.version 0.1
/// Last update 2024-03-21
/// <summary>

using System;
using exeptions;

namespace Mathlib
{
    public class Operations
    {
        /// <summary>
        /// Function to add
        /// <summary>
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        /// <summary>
        /// Function to sub
        /// <summary>
        public static double Sub(double num1, double num2)
        {
            return num1 - num2;
        }
        /// <summary>
        /// Function to mul
        /// <summary>
        public static double Mul(double num1, double num2)
        {
            return num1 * num2;
        }
        /// <summary>
        /// Function to div
        /// throws exeption if we division by 0
        /// <summary>
        public static double Div(double num1, double num2)
        {
            if (num2 == 0.0)
            {
                throw new DivZeroException("Division by zero is not possible.");
            }
            return num1 / num2;
        }


        /// <summary>
        /// Function to modulo
        /// throws exeption if we do modulo by 0
        /// <summary>
        public static double Mod(double num1, double num2)
        {
            if (num2 == 0.0)
            {
                throw new ModExeption("Modulo by zero is not possible.");
            }
            return num1 - Math.Floor(num1 / num2) * num2;
        }
        /// <summary>
        /// Function to power
        /// throws exeption if we do power by non Natural number
        /// if we power by zero or power zero it throws 1
        /// <summary>
        public static double Pow(double num1, double num2)
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
        /// <summary>
        /// Function to sqrt
        /// throws exeption if we do sqrt by non Natural number
        /// throws exeption if we sqrt negative number
        /// throws exeption if we do sqrt by zero
        /// <summary>
        public static double Sqrt(double num1, double num2)
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
        /// <summary>
        /// Function to faktorial
        /// throws exeption if we do faktorial by negative number
        /// <summary>
        public static int Faktorial(int num1)
        {
            if (num1 < 0)
            {
                throw new FactorialExeption("Negative number is not allowed in faktorial.");
            }else
            {
                int j = 1;
                for (int i = 2; i <= num1; i++)
                {
                    j *= i;
                }
                return j;
            }
        }
    }
}