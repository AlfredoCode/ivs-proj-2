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
            keyInput.Completed += OnEnterPressed;
        }

        private void OnEnterPressed(object sender, EventArgs e)
        {
            OnEquals(sender, e);
        }
        private void OnPageLoaded(object sender, EventArgs e)
        {
            keyInput.Focus();
        }


        private void OnTextInput(object sender, TextChangedEventArgs e)
        {
            string input = e.NewTextValue;
            switch (input)
            {
                case "0":
                    OnNumberSelection0(sender, e);
                    break;
                case "1":
                    OnNumberSelection1(sender, e);
                    break;
                case "2":
                    OnNumberSelection2(sender, e);
                    break;
                case "3":
                    OnNumberSelection3(sender, e);
                    break;
                case "4":
                    OnNumberSelection4(sender, e);
                    break;
                case "5":
                    OnNumberSelection5(sender, e);
                    break;
                case "6":
                    OnNumberSelection6(sender, e);
                    break;
                case "7":
                    OnNumberSelection7(sender, e);
                    break;
                case "8":
                    OnNumberSelection8(sender, e);
                    break;
                case "9":
                    OnNumberSelection9(sender, e);
                    break;
                case "+":
                    OnAdd(sender, e);
                    break;
                case "-":
                    OnSub(sender, e);
                    break;
                case "*":
                    OnMultiply(sender, e);
                    break;
                case "/":
                    OnDivision(sender, e);
                    break;
                case "^":
                    OnSquared(sender, e);
                    break;
                case "√":
                    OnSquareRoot(sender, e);
                    break;
                case "!":
                    OnFactorial(sender, e);
                    break;
                case "R":
                    OnRandom(sender, e);
                    break;
                case "%":
                    OnModulo(sender, e);
                    break;
                case "π":
                    OnPi(sender, e);
                    break;
                case ",":
                    OnComma(sender, e);
                    break;
                default:
                    break;
            }

            // Clear the text in the keyInput Entry after each input
            keyInput.Text = string.Empty;
        }
        void OnClear(object sender, EventArgs e)
        {
            result.Text = "0";
            keyInput.Focus();
        }

        void OnSquared(object sender, EventArgs e)
        {
            result.Text += "^";
            keyInput.Focus();
        }

        void OnSquareRoot(object sender, EventArgs e)
        {
            result.Text += "√";
            keyInput.Focus();
        }

        void OnNumberSelection0(object sender, EventArgs e)
        {
            result.Text += "0";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
            keyInput.Focus();
        }

        void OnNumberSelection1(object sender, EventArgs e)
        {
            result.Text += "1";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
            keyInput.Focus();
        }

        void OnNumberSelection2(object sender, EventArgs e)
        {
            result.Text += "2";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
            keyInput.Focus();
        }

        void OnNumberSelection3(object sender, EventArgs e)
        {
            result.Text += "3";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
            keyInput.Focus();
        }

        void OnNumberSelection4(object sender, EventArgs e)
        {
            result.Text += "4";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
            keyInput.Focus();
        }

        void OnNumberSelection5(object sender, EventArgs e)
        {
            result.Text += "5";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
            keyInput.Focus();
        }

        void OnNumberSelection6(object sender, EventArgs e)
        {
            result.Text += "6";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
            keyInput.Focus();
        }

        void OnNumberSelection7(object sender, EventArgs e)
        {
            result.Text += "7";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
            keyInput.Focus();
        }

        void OnNumberSelection8(object sender, EventArgs e)
        {
            result.Text += "8";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
            keyInput.Focus();
        }

        void OnNumberSelection9(object sender, EventArgs e)
        {
            result.Text += "9";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
            keyInput.Focus();
        }

        void OnDivision(object sender, EventArgs e)
        {
            result.Text += "/";
            keyInput.Focus();
        }

        void OnMultiply(object sender, EventArgs e)
        {
            result.Text += "*";
            keyInput.Focus();
        }

        void OnSub(object sender, EventArgs e)
        {
            result.Text += "-";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
            keyInput.Focus();
        }

        void OnAdd(object sender, EventArgs e)
        {
            result.Text += "+";
            keyInput.Focus();
        }

        void OnFactorial(object sender, EventArgs e)
        {
            result.Text += "!";
            keyInput.Focus();
        }

        void OnRandom(object sender, EventArgs e)
        {
            result.Text += "R";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
            keyInput.Focus();
        }

        void OnModulo(object sender, EventArgs e)
        {
            result.Text += "%";
            keyInput.Focus();
        }

        void OnPi(object sender, EventArgs e)
        {
            result.Text += "π";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
            keyInput.Focus();
        }

        void OnComma(object sender, EventArgs e)
        {
            result.Text += ",";
            keyInput.Focus();
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
            keyInput.Focus();
        }

    }
}
