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
            result.Text = "^";
        }
        void OnSquareRoot(object sender, EventArgs e)
        {   
            result.Text += "√";
        }
        void OnNumberSelection0(object sender, EventArgs e)
        {
            result.Text += "0";
        }
        void OnNumberSelection1(object sender, EventArgs e)
        {
            result.Text += "1";
        }
        void OnNumberSelection2(object sender, EventArgs e)
        {
            result.Text += "2";
        }
        void OnNumberSelection3(object sender, EventArgs e)
        {
            result.Text += "3";
        }
        void OnNumberSelection4(object sender, EventArgs e)
        {
            result.Text += "4";
        }
        void OnNumberSelection5(object sender, EventArgs e)
        {
            result.Text += "5";
        }
        void OnNumberSelection6(object sender, EventArgs e)
        {
            result.Text += "6";
        }
        void OnNumberSelection7(object sender, EventArgs e)
        {
            result.Text += "7";
        }
        void OnNumberSelection8(object sender, EventArgs e)
        {
            result.Text += "8";
        }
        void OnNumberSelection9(object sender, EventArgs e)
        {
            result.Text += "9";
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
            Random random = new Random(100);
            result.Text += "" + random;
        }
        void OnModulo(object sender, EventArgs e)
        {
            result.Text += "%";
        }
        void OnPi(object sender, EventArgs e)
        {
            result.Text += "3.14159265359";
        }
        void OnComma(object sender, EventArgs e)
        {
            result.Text += ",";
        }
        void OnEquals(object sender, EventArgs e)
        {
            result.Text = "" + Mathlib.Operations.calculate(result.Text);
        }
    }
}
