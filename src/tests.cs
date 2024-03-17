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
using NUnit.Framework;

public class MathlibTests
{
    private Mathlib mathlib;

    [SetUp]
    public void Setup()
    {
        mathlib = new Mathlib();
    }
    /// <summary>
    /// Add test to check if add works correctly
    /// checks: normal use of add
    /// checks: negative numbers
    /// checks: zero
    /// checks: number betwean 0 and one
    /// </summary>
    [Test]
    public void add_test()
    {
        double num1 = 2;
        double num2 = 9;
        double result = mathlib.add(num1, num2);
        Assert.AreEqual(11, result);
    }
    [Test]
    public void add_negative_test()
    {
        double num1 = 2;
        double num2 = -9;
        double result = mathlib.add(num1, num2);
        Assert.AreEqual(-7, result);
    }
    [Test]
    public void add_zero_test()
    {
        double num1 = 2;
        double num2 = 0;
        double result = mathlib.add(num1, num2);
        Assert.AreEqual(2, result);
    }
    [Test]
    public void add_bellow_one_test()
    {
        double num1 = 0.1;
        double num2 = 0.7;
        double result = mathlib.add(num1, num2);
        Assert.AreEqual(0.8, result);
    }
    /// <summary>
    /// Sub test to check if sub works correctly
    /// checks: normal use of sub
    /// checks: going bellow zero
    /// checks: negative numbers
    /// checks: zero
    /// checks: number betwean 0 and one
    /// </summary>
    [Test]
    public void sub_test()
    {
        double num1 = 9;
        double num2 = 5;
        double result = mathlib.sub(num1, num2);
        Assert.AreEqual(4, result);
    }
    [Test]
    public void sub_bellow_zero_test()
    {
        double num1 = 5;
        double num2 = 10;
        double result = mathlib.sub(num1, num2);
        Assert.AreEqual(-5, result);
    }
    [Test]
    public void sub_negative_test()
    {
        double num1 = 9;
        double num2 = -5;
        double result = mathlib.sub(num1, num2);
        Assert.AreEqual(14, result);
    }
    [Test]
    public void sub_zero_test()
    {
        double num1 = 9;
        double num2 = 0;
        double result = mathlib.sub(num1, num2);
        Assert.AreEqual(9, result);
    }
    [Test]
    public void sub_bellow_one_test()
    {
        double num1 = 0.7;
        double num2 = 0.1;
        double result = mathlib.sub(num1, num2);
        Assert.AreEqual(0.6, result);
    }
    /// <summary>
    /// Mul test to check if mul works correctly
    /// checks: normal use of mul
    /// checks: negative numbers
    /// checks: zero
    /// checks: number betwean 0 and one
    /// </summary>
    [Test]
    public void mul_test()
    {
        double num1 = 9;
        double num2 = 5;
        double result = mathlib.mul(num1, num2);
        Assert.AreEqual(45, result);
    }
    [Test]
    public void mul_neg_test()
    {
        double num1 = 5;
        double num2 = -10;
        double result = mathlib.mul(num1, num2);
        Assert.AreEqual(-50, result);
    }
    [Test]
    public void mul_zero_test()
    {
        double num1 = 9;
        double num2 = 0;
        double result = mathlib.mul(num1, num2);
        Assert.AreEqual(0, result);
    }
    [Test]
    public void mul_bellow_one_test()
    {
        double num1 = 0.7;
        double num2 = 0.1;
        double result = mathlib.mul(num1, num2);
        Assert.AreEqual(0.07, result);
    }
    /// <summary>
    /// Div test to check if div works correctly
    /// checks: normal use of div
    /// checks: negative numbers
    /// checks: zero
    /// checks: number betwean 0 and one
    /// </summary>
    [Test]
    public void div_test()
    {
        double num1 = 9;
        double num2 = 3;
        double result = mathlib.div(num1, num2);
        Assert.AreEqual(3, result);
    }
    [Test]
    public void div_negative_test()
    {
        double num1 = 10;
        double num2 = -5;
        double result = mathlib.div(num1, num2);
        Assert.AreEqual(-2, result);
    }
    [Test]
    public void div_zero_test()
    {
        double num1 = 9;
        double num2 = 0;
        Assert.Throws<DivideByZeroException>(() => mathlib.div(num1, num2), "Division by zero is not possible.");
    }
    [Test]
    public void div_bellow_one_test()
    {
        double num1 = 0.5;
        double num2 = 0.5;
        double result = mathlib.diviv(num1, num2);
        Assert.AreEqual(0.25, result);
    }
    /// <summary>
    /// Faktorial test to check if faktorial works correctly
    /// checks: normal use of faktorial
    /// checks: negative numbers
    /// checks: zero
    /// checks: number betwean 0 and one
    /// </summary>
    [Test]
    public void faktorial_test()
    {
        double num1 = 5;
        double result = mathlib.Faktorial(a);
        Assert.AreEqual(120, result);
    }
    [Test]
    public void faktorial_negative_test()
    {
        double num1 = -5;
        Assert.Throws<NegativeFactorialException>(() => mathlib.Faktorial(a), "Negative number is not allowed in faktorial.");
    }
    [Test]
    public void faktorial_zero_test()
    {
        double num1 = 0;
        double result = mathlib.Faktorial(a);
        Assert.AreEqual(1, result);
    }
    [Test]
    public void faktorial_below_one_test()
    {
        double num1 = 0.2;
        double result = mathlib.Faktorial(a);
        Assert.AreEqual(0,9181687423997606, result);
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
    [Test]
    public void power_test()
    {
        double num1 = 5;
        double num2 = 3;
        double result = mathlib.Power(num1, num2);
        Assert.AreEqual(125, result);
    }
    [Test]
    public void power_zero_test()
    {
        double num1 = 5;
        double num2 = 0;
        double result = mathlib.Power(num1, num2);
        Assert.AreEqual(1, result);
    }
    [Test]
    public void power_negative_odd_test()
    {
        double num1 = -5;
        double num2 = 3;
        double result = mathlib.Power(num1, num2);
        Assert.AreEqual(-125, result);
    }
    [Test]
    public void power_negative_even_test()
    {
        double num1 = -5;
        double num2 = 2;
        double result = mathlib.Power(num1, num2);
        Assert.AreEqual(25, result);
    }
    [Test]
    public void power_negative_power_test()
    {
        double num1 = 5;
        double num2 = -3;
        Assert.Throws<PowerException>(() => mathlib.Power(num1, num2), "Power hawe to be natural number.");
    }
    [Test]
    public void power_bellow_one_test()
    {
        double num1 = 4;
        double num2 = 0.5;
        Assert.Throws<PowerException>(() => mathlib.Power(num1, num2), "Power hawe to be natural number.");
    }
    /// <summary>
    /// Sqrt test to check if square root works correctly
    /// checks: normal use of square root
    /// checks: number betwean 0 and one
    /// checks: negative rooted number
    /// checks: negative numbers rooted by
    /// checks: zero
    /// </summary>
    [Test]
    public void sqrt_test()
    {
        double num1 = 25;
        double num2 = 2;
        double result = mathlib.Sqrt(a);
        Assert.AreEqual(5, result);
    }
    [Test]
    public void sqrt_bellow_one_test()
    {
        double num1 = 4;
        double num2 = 0.5;
        Assert.Throws<SqrtException>(() => mathlib.Sqrt(num1, num2), "Square root hawe to be natural number.");
    }
    [Test]
    public void sqrt_negative_root_test()
    {
        double num1 = -5;
        double num2 = 5;
        Assert.Throws<SqrtNegativeException>(() => mathlib.Sqrt(num1, num2), "Negative numbers cant be square rooted.");
    }
    [Test]
    public void sqrt_negative_number_test()
    {
        double num1 = 5;
        double num2 = -5;
        Assert.Throws<SqrtException>(() => mathlib.Sqrt(num1, num2), "Square root hawe to be natural number.");
    }
    [Test]
    public void sqrt_zero_test()
    {
        double num1 = 5;
        double num2 = 0;
        Assert.Throws<SqrtInfiniteException>(() => mathlib.Sqrt(num1, num2), "Infinity.");
    }

    /// <summary>
    /// Mod test to check if mod works correctly
    /// checks: normal use of Mod
    /// checks: zero
    /// checks: number betwean 0 and one
    /// checks: negative numbers
    /// </summary>
    [Test]
    public void mod_test()
    {
        double num1 = 5;
        double num2 = 3;
        double result = mathlib.Mod(num1, num2);
        Assert.AreEqual(2, result);
    }
    [Test]
    public void mod_zero_test()
    {
        double num1 = 5;
        double num2 = 0;
        double result = mathlib.Mod(num1, num2);
        Assert.AreEqual(5, result); 
    }
    [Test]
    public void mod_bellow_one_test()
    {
        double num1 = 5;
        double num2 = 0.3;
        double result = mathlib.Mod(num1, num2);
        Assert.AreEqual(0.2, result);
    }
    [Test]
    public void mod_negative__test()
    {
        double num1 = 7;
        double num2 = -3;
        double result = mathlib.Mod(num1, num2);
        Assert.AreEqual(-2, result);
    }
}