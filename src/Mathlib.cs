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
using NUnit.Framework;
using Mathlib;

public class Mathlib
{
    public double add(double num1, double num2)
    {
        return num1 + num2;
    }
    public double sub(double num1, double num2)
    {
        return num1 - num2;
    }
    public double mul(double num1, double num2)
    {
        return num1 * num2;
    }
    public double div(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Division by zero is not possible.");
        }
        return num1 / num2;
    }
    public double Mod(double num1, double num2)
    {
        return num1 % num2;
    }
    public double pow(double num1, double num2)
    {
        if (num2 < 0 || num2 % 1 != 0)
        {
            throw new NegativePowerException( "Power have to be natural number.");
        }else if (num1 == 0)
        {
            return 0;
        }else if (num2 == 0)
        {
            return 1;
        }else
        {
            j = num1;
            for (int i = 0; i < num2 - 1; i++)
            {
                num1 = num1 * j;
            }
            return num1
        }
    }
    public double sqrt(double num1, double num2)
    {
        if (num2 < 0 || num2 % 1 != 0)
        {
            throw new SqrtException("Square root have to be natural number.");
        } else if (num1 < 0)
        {
            throw new SqrtNegativeException("Negative numbers cant be square rooted.");
        } else if (num2 == 0)
        {
            throw new SqrtInfiniteException("Infinity.");
        }
        return Math.Sqrt(num1, num2);
    }
    public double faktorial(double num1)
    {
        if (num1 < 0)
        {
            throw new NegativeFactorialException("Negative number is not allowed in faktorial.");
        }else
        {
            for (num1; num1 < 0; num1--)
            {
                num1 = num1 * i;
            }
            return Math.Factorial(num1);   
        }
    }
}