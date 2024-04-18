/// <summary>
/// MainPage.xaml.cs
/// 
/// Dominik Hofman (xhofma11)
/// Tomas Skypala (xskypa03)
/// Jana Veronika Moskvova (xmoskv01)
///
/// Implementation of MainPage
/// Last update 2024-04-18
/// <summary>

using System.Globalization;
using Mathlib;
using System;
using System.Text.RegularExpressions;

namespace calculadora
{
    /// <summary>
    /// Represents the main page of the calculator application.
    /// </summary>
    public partial class MainPage : ContentPage
    {

        /// <summary>
        /// Initializes a new instance of the MainPage class.
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
            keyInput.Completed += OnEnterPressed;
        }

        /// <summary>
        /// Handles the event when the enter key is pressed.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void OnEnterPressed(object sender, EventArgs e)
        {
            OnEquals(sender, e);
        }

        /// <summary>
        /// Handles the event when the page is loaded.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void OnPageLoaded(object sender, EventArgs e)
        {
            keyInput.Focus();
        }


        /// <summary>
        /// Handles the event when text input is entered.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void OnTextInput(object sender, TextChangedEventArgs e)
        {
            string input = e.NewTextValue;
            switch (input)
            {
                case "c":
                    OnClear(sender, e);
                    break;
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
                case "!":
                    OnFactorial(sender, e);
                    break;
                case "r":
                    OnRandom(sender, e);
                    break;
                case "%":
                    OnModulo(sender, e);
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
        /// <summary>
        /// Clears the result text and sets it to "0".
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        void OnClear(object sender, EventArgs e)
        {
            result.Text = "0";
            keyInput.Focus();
        }

        /// <summary>
        /// Appends "^" to the result text.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        void OnSquared(object sender, EventArgs e)
        {
            result.Text += "^";
            keyInput.Focus();
        }

        /// <summary>
        /// Appends "√" to the result text.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        void OnSquareRoot(object sender, EventArgs e)
        {
            result.Text += "√";
            keyInput.Focus();
        }

        /// <summary>
        /// Appends "0" to the result text and removes leading zeros.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        void OnNumberSelection0(object sender, EventArgs e)
        {
            result.Text += "0";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
            keyInput.Focus();
        }

        /// <summary>
        /// Appends "1" to the result text and removes leading zeros.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        void OnNumberSelection1(object sender, EventArgs e)
        {
            result.Text += "1";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
            keyInput.Focus();
        }

        /// <summary>
        /// Appends "2" to the result text and removes leading zeros.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        void OnNumberSelection2(object sender, EventArgs e)
        {
            result.Text += "2";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
            keyInput.Focus();
        }

        /// <summary>
        /// Appends "3" to the result text and removes leading zeros.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        void OnNumberSelection3(object sender, EventArgs e)
        {
            result.Text += "3";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
            keyInput.Focus();
        }

        /// <summary>
        /// Appends "4" to the result text and removes leading zeros.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        void OnNumberSelection4(object sender, EventArgs e)
        {
            result.Text += "4";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
            keyInput.Focus();
        }

        /// <summary>
        /// Appends "5" to the result text and removes leading zeros.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        void OnNumberSelection5(object sender, EventArgs e)
        {
            result.Text += "5";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
            keyInput.Focus();
        }

        /// <summary>
        /// Appends "6" to the result text and removes leading zeros.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        void OnNumberSelection6(object sender, EventArgs e)
        {
            result.Text += "6";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
            keyInput.Focus();
        }

        /// <summary>
        /// Appends "7" to the result text and removes leading zeros.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        void OnNumberSelection7(object sender, EventArgs e)
        {
            result.Text += "7";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
            keyInput.Focus();
        }

        /// <summary>
        /// Appends "8" to the result text and removes leading zeros.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        void OnNumberSelection8(object sender, EventArgs e)
        {
            result.Text += "8";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
            keyInput.Focus();
        }

        /// <summary>
        /// Appends "9" to the result text and removes leading zeros.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        void OnNumberSelection9(object sender, EventArgs e)
        {
            result.Text += "9";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
            keyInput.Focus();
        }

        /// <summary>
        /// Appends "/" to the result text.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        void OnDivision(object sender, EventArgs e)
        {
            result.Text += "/";
            keyInput.Focus();
        }

        /// <summary>
        /// Appends "*" to the result text.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        void OnMultiply(object sender, EventArgs e)
        {
            result.Text += "*";
            keyInput.Focus();
        }

        /// <summary>
        /// Appends "-" to the result text and removes leading zeros.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        void OnSub(object sender, EventArgs e)
        {
            result.Text += "-";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
            keyInput.Focus();
        }

        /// <summary>
        /// Appends "+" to the result text.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        void OnAdd(object sender, EventArgs e)
        {
            result.Text += "+";
            keyInput.Focus();
        }

        /// <summary>
        /// Appends "!" to the result text.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        void OnFactorial(object sender, EventArgs e)
        {
            result.Text += "!";
            keyInput.Focus();
        }

        /// <summary>
        /// Appends "R" to the result text and removes leading zeros.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        void OnRandom(object sender, EventArgs e)
        {
            result.Text += "R";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
            keyInput.Focus();
        }

        /// <summary>
        /// Appends "%" to the result text.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        void OnModulo(object sender, EventArgs e)
        {
            result.Text += "%";
            keyInput.Focus();
        }

        /// <summary>
        /// Appends "π" to the result text and removes leading zeros.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        void OnPi(object sender, EventArgs e)
        {
            result.Text += "π";
            result.Text = Mathlib.Operations.ridoff0(result.Text);
            keyInput.Focus();
        }

        /// <summary>
        /// Appends "," to the result text.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        void OnComma(object sender, EventArgs e)
        {
            result.Text += ",";
            keyInput.Focus();
        }

        /// <summary>
        /// Tries to evaluate the expression in the result text and updates the result text accordingly.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
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
