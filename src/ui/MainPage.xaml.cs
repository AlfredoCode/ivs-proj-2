using System.Globalization;
using Mathlib;
using System;
using System.Text.RegularExpressions;

namespace calculadora
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        void OnClear(object sender, EventArgs e)
        {
            result.Text = "0";
        }
        void OnSquared(object sender, EventArgs e)
        {
            result.Text += "^";
        }
        void OnSquareRoot(object sender, EventArgs e)
        {
            result.Text += "√";
        }
        void OnNumberSelection0(object sender, EventArgs e)
        {
            result.Text += "0";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
        }
        void OnNumberSelection1(object sender, EventArgs e)
        {
            result.Text += "1";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
        }
        void OnNumberSelection2(object sender, EventArgs e)
        {
            result.Text += "2";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
        }
        void OnNumberSelection3(object sender, EventArgs e)
        {
            result.Text += "3";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
        }
        void OnNumberSelection4(object sender, EventArgs e)
        {
            result.Text += "4";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
        }
        void OnNumberSelection5(object sender, EventArgs e)
        {
            result.Text += "5";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
        }
        void OnNumberSelection6(object sender, EventArgs e)
        {
            result.Text += "6";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
        }
        void OnNumberSelection7(object sender, EventArgs e)
        {
            result.Text += "7";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
        }
        void OnNumberSelection8(object sender, EventArgs e)
        {
            result.Text += "8";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
        }
        void OnNumberSelection9(object sender, EventArgs e)
        {
            result.Text += "9";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
        }
        void OnDivision(object sender, EventArgs e)
        {
            result.Text += "/";
        }
        void OnMultiply(object sender, EventArgs e)
        {
            result.Text += "*";
        }
        void OnSub(object sender, EventArgs e)
        {
            result.Text += "-";
        }
        void OnAdd(object sender, EventArgs e)
        {
            result.Text += "+";
        }
        void OnFactorial(object sender, EventArgs e)
        {
            result.Text += "!";
        }
        void OnRandom(object sender, EventArgs e)
        {
            result.Text += "R";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
        }
        void OnModulo(object sender, EventArgs e)
        {
            result.Text += "%";
        }
        void OnPi(object sender, EventArgs e)
        {
            result.Text += "π";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
        }
        void OnComma(object sender, EventArgs e)
        {
            result.Text += ",";
        }
        void OnEquals(object sender, EventArgs e)
        {
            try
            {
                result.Text = Mathlib.Operations.calculate(result.Text);
            }
            catch (Exception ex)
            {
                result.Text = ex.Message;
            }
        }
    }
}
