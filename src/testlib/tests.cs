/// <summary>
/// tests.cs
/// 
/// Tomas Skypala (xskypa03)
///
/// Implementation of tests for Mathlib.version 0.1
/// Last update 2024-03-21
/// <summary>
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathlib;
using exeptions;

namespace OperationsTests
{
    [TestClass]
    public class Tests
    {

        private const double Accuracy = 1e-6;
        /// <summary>
        /// Add test to check if add works correctly
        /// checks: normal use of add
        /// checks: negative numbers
        /// checks: zero
        /// checks: number betwean 0 and one
        /// </summary>
        [TestMethod]
        public void Add_Test()
        {
            Assert.AreEqual(11, Operations.Add(2, 9), Accuracy);//normal use of add
            Assert.AreEqual(-7, Operations.Add(2, -9), Accuracy);//negative numbers
            Assert.AreEqual(2, Operations.Add(2, 0), Accuracy);//zero
            Assert.AreEqual(0.8, Operations.Add(0.1, 0.7), Accuracy);//number betwean 0 and one
        }
        /// <summary>
        /// Sub test to check if sub works correctly
        /// checks: normal use of sub
        /// checks: going bellow zero
        /// checks: negative numbers
        /// checks: zero
        /// checks: number betwean 0 and one
        /// </summary>
        [TestMethod]
        public void Sub_Test()
        {
            Assert.AreEqual(4, Operations.Sub(9, 5), Accuracy);//normal use of sub
            Assert.AreEqual(-5, Operations.Sub(5, 10), Accuracy);//going bellow zero
            Assert.AreEqual(14, Operations.Sub(9, -5), Accuracy);//negative numbers
            Assert.AreEqual(9, Operations.Sub(9, 0), Accuracy);//zero
            Assert.AreEqual(0.6, Operations.Sub(0.7, 0.1), Accuracy);//number betwean 0 and one
        }
        /// <summary>
        /// Mul test to check if mul works correctly
        /// checks: normal use of mul
        /// checks: negative numbers
        /// checks: zero
        /// checks: number betwean 0 and one
        /// </summary>
        [TestMethod]
        public void Mul_Test()
        {
            Assert.AreEqual(45, Operations.Mul(9, 5), Accuracy);//normal use of mul
            Assert.AreEqual(-50, Operations.Mul(5, -10), Accuracy);//negative numbers
            Assert.AreEqual(0, Operations.Mul(9, 0), Accuracy);//zero
            Assert.AreEqual(0.07, Operations.Mul(0.7, 0.1), Accuracy);//number betwean 0 and one
        }
        /// <summary>
        /// Div test to check if div works correctly
        /// checks: normal use of div
        /// checks: negative numbers
        /// checks: zero
        /// checks: number betwean 0 and one
        /// </summary>
        [TestMethod]
        public void Division_Test()
        {
            Assert.AreEqual(3, Operations.Div(9, 3), Accuracy);//normal use of div
            Assert.AreEqual(-2, Operations.Div(10, -5), Accuracy);//negative numbers
            try//zero
            {
                Operations.Div(9, 0);
            }
            catch (DivZeroException)
            {
            }
            Assert.AreEqual(1, Operations.Div(0.5, 0.5), Accuracy);//number betwean 0 and one
        }
        /// <summary>
        /// Faktorial test to check if faktorial works correctly
        /// checks: normal use of faktorial
        /// checks: negative numbers
        /// checks: zero
        /// </summary>
        [TestMethod]
        public void Factorial_Test()
        {
            Assert.AreEqual(120, Operations.Faktorial(5), Accuracy);//normal use of faktorial
            try//negative number
            {
                Operations.Faktorial(-5);
            }
            catch (FactorialExeption)
            {
            }
            Assert.AreEqual(1, Operations.Faktorial(0), Accuracy);//zero
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
        [TestMethod]
        public void Power_Test()
        {
            Assert.AreEqual(125, Operations.Pow(5, 3), Accuracy);//normal use of power
            Assert.AreEqual(1, Operations.Pow(5, 0), Accuracy);//zero
            Assert.AreEqual(-125, Operations.Pow(-5, 3), Accuracy);//negative numbers (odd)
            Assert.AreEqual(25, Operations.Pow(-5, 2), Accuracy);//negative numbers (even)
            try//negative power
            {
                Operations.Pow(5, -3);
            }
            catch (PowNaturalException)
            {
            }
            try//number betwean 0 and one
            {
                Operations.Pow(4, 0.5);
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
        [TestMethod]
        public void Sqrt_Test()
        {
            Assert.AreEqual(5, Operations.Sqrt(25, 2), Accuracy);//normal use of square root
            try//number betwean 0 and one
            {
                Operations.Sqrt(4, 0.5);
            }
            catch (SqrtNaturalExeption)
            {
            }
            try//negative rooted number
            {
                Operations.Sqrt(-5, 5);
            }
            catch (SqrtNegExeption)
            {
            }
            try//negative numbers rooted by
            {
                Operations.Sqrt(5, -3);
            }
            catch (SqrtNaturalExeption)
            {
            }
            try//zero
            {
                Operations.Sqrt(5, 0);
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
        [TestMethod]
        public void Mod_test()
        {
            Assert.AreEqual(2, Operations.Mod(5, 3), Accuracy);//normal use of Mod
            try//zero
            {
                Operations.Mod(5, 0);
            }
                catch (ModExeption)
            {
            }
            Assert.AreEqual(0.2, Operations.Mod(5, 0.3), Accuracy);//number betwean 0 and one
            Assert.AreEqual(0.1, Operations.Mod(5.5, 0.3), Accuracy);
            Assert.AreEqual(-2, Operations.Mod(7, -3), Accuracy);//negative numbers
            Assert.AreEqual(2, Operations.Mod(-7, 3), Accuracy);
        }
    }
}