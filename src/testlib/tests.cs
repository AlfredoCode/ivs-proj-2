/// <summary>
/// tests.cs
/// 
/// Dominik Hofman (xhofma11)
/// Jana Veronika Moskvová (xmoskv01)
/// Tomas Skypala (xskypa03)
/// Erik Žák (xzaker00)
///
/// Implementation of tests for Mathlib.version 0.1
/// Last update 2024-03-16
/// <summary>
using System;
using Xunit;
using Mathlib;
using exeptions;

namespace MathlibTests
{
    public class Tests
    {
        private Operations mathlib;

        [Fact]
        public void Tests_Setup()
        {
            mathlib = new Operations();
        }
        /// <summary>
        /// Add test to check if add works correctly
        /// checks: normal use of add
        /// checks: negative numbers
        /// checks: zero
        /// checks: number betwean 0 and one
        /// </summary>
        [Theory]
        [InlineData(2, 9, 11)] //normal use of add
        [InlineData(2, -9, -7)] //negative numbers
        [InlineData(2, 0, 2)] //zero
        [InlineData(0.1, 0.7, 0.8)] //number betwean 0 and one
        public void Add_Test(double num1, double num2, double expectedResult)
        {
            Assert.Equal(expectedResult, mathlib.Add(num1, num2));
        }
        /// <summary>
        /// Sub test to check if sub works correctly
        /// checks: normal use of sub
        /// checks: going bellow zero
        /// checks: negative numbers
        /// checks: zero
        /// checks: number betwean 0 and one
        /// </summary>
        [Theory]
        [InlineData(9, 5, 4)] //normal use of sub
        [InlineData(5, 10, -5)] //going bellow zero
        [InlineData(9, -5, 14)] //negative numbers
        [InlineData(9, 0, 9)] //zero
        [InlineData(0.7, 0.1, 0.6)] //number betwean 0 and one
        public void Sub_Test(double num1, double num2, double expectedResult)
        {
            Assert.Equal(expectedResult, mathlib.Sub(num1, num2));

        }
        /// <summary>
        /// Mul test to check if mul works correctly
        /// checks: normal use of mul
        /// checks: negative numbers
        /// checks: zero
        /// checks: number betwean 0 and one
        /// </summary>
        [Theory]
        [InlineData(9, 5, 45)] //normal use of mul
        [InlineData(5, -10, -50)] //negative numbers
        [InlineData(9, 0, 0)] //zero
        [InlineData(0.7, 0.1, 0.07)] //number betwean 0 and one
        public void Mul_Test(double num1, double num2, double expectedResult)
        {
            Assert.Equal(expectedResult, mathlib.Mul(num1, num2));
        }
        /// <summary>
        /// Div test to check if div works correctly
        /// checks: normal use of div
        /// checks: negative numbers
        /// checks: zero
        /// checks: number betwean 0 and one
        /// </summary>
        [Fact]
        public void Division_Test()
        {
            Assert.Equal(3, mathlib.Div(9, 3));//normal use of div
            Assert.Equal(-2, mathlib.Div(10, -5));//negative numbers
            try//zero
            {
                mathlib.Div(9, 0);
            }
            catch (DivZeroException)
            {
            }
            Assert.Equal(1, mathlib.Div(0.5, 0.5));//number betwean 0 and one
        }
        /// <summary>
        /// Faktorial test to check if faktorial works correctly
        /// checks: normal use of faktorial
        /// checks: negative numbers
        /// checks: zero
        /// checks: number betwean 0 and one
        /// </summary>
        [Fact]
        public void Factorial_Test()
        {
            Assert.Equal(120, mathlib.Faktorial(5), mathlib.Faktorial(5));//normal use of faktorial
            try//negative number
            {
                mathlib.Faktorial(-5);
            }
            catch (FactorialExeption)
            {
            }
            Assert.Equal(1, mathlib.Faktorial(0));//zero
            Assert.Equal(0,9181687, mathlib.Faktorial(0.2));//number betwean 0 and one
        }
        /// <summary>
        /// Power test to check if power works correctly
        /// checks: normal use of power
        /// checks: zero
        /// checks: negative numbers (odd)
        /// checks: negative numbers (even)
        /// checks: negative power
        /// checks: number betwean 0 and one
        /// </summary>
        [Fact]
        public void Power_Test()
        {
            Assert.Equal(125, mathlib.Pow(5, 3));//normal use of power
            Assert.Equal(1, mathlib.Pow(5, 0));//zero
            Assert.Equal(-125, mathlib.Pow(-5, 3));//negative numbers (odd)
            Assert.Equal(25, mathlib.Pow(-5, 2));//negative numbers (even)
            try//negative power
            {
                mathlib.Pow(5, -3);
            }
            catch (PowNaturalException)
            {
            }
            try//number betwean 0 and one
            {
                mathlib.Pow(4, 0.5);
            }
            catch (PowNaturalException)
            {
            }
        }
        /// <summary>
        /// Sqrt test to check if square root works correctly
        /// checks: normal use of square root
        /// checks: number betwean 0 and one
        /// checks: negative rooted number
        /// checks: negative numbers rooted by
        /// checks: zero
        /// </summary>
        [Fact]
        public void Sqrt_Test()
        {
            Assert.Equal(5, mathlib.Sqrt(25, 2));//normal use of square root
            try//number betwean 0 and one
            {
                mathlib.Sqrt(4, 0.5);
            }
            catch (SqrtNaturalExeption)
            {
            }
            try//negative rooted number
            {
                mathlib.Sqrt(-5, 5);
            }
            catch (SqrtNegExeption)
            {
            }
            Assert.Equal(125, mathlib.Sqrt(5, -3));//negative numbers rooted by
            try//zero
            {
                mathlib.Sqrt(5, 0);
            }
            catch (SqrtbyZeroExeption)
            {
            }
        }

        /// <summary>
        /// Mod test to check if mod works correctly
        /// checks: normal use of Mod
        /// checks: zero
        /// checks: number betwean 0 and one
        /// checks: negative numbers
        /// </summary>
        [Theory]
        [InlineData(5, 3, 2)] //normal use of Mod
        [InlineData(5, 0, 5)] //zero
        [InlineData(5, 0.3, 0.2)] //number betwean 0 and one
        [InlineData(7, -3, -2)] //negative numbers
        public void Mod_test(double num1, double num2, double result)
        {
            Assert.Equal(result, mathlib.Mod(num1, num2));
        }
    }
}