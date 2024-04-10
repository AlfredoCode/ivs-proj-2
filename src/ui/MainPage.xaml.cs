using System.Globalization;
using Calculator.Mathlib;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace calculadora
{
    public partial class MainPage : ContentPage
    {

        public string calculate(string infixExpression)
        {
            // Zásobník pro operátory
            Stack<sting> operatorStack = new Stack<string>();

            // Výstupní postfixový řetězec
            string postfixExpression = "";

            // Procházení infixového výrazu
            foreach (char c in infixExpression)
            {
                // Operandy
                if (char.IsLetterOrDigit(c))
                {
                    postfixExpression += c;
                }
                // Operátory a závorky
                else
                {
                    switch (c)
                    {
                        case '+':
                        case '-':
                            // Vyprázdnění zásobníku s operátory s nižší prioritou
                            while (operatorStack.Count > 0 && Precedence(operatorStack.Peek()) >= Precedence(c))
                            {
                                postfixExpression += operatorStack.Pop();
                            }
                            operatorStack.Push(c);
                            break;
                        case '*':
                        case '/':
                        case '%':
                            // Vyprázdnění zásobníku s operátory s prioritou menší nebo rovnou
                            while (operatorStack.Count > 0 && Precedence(operatorStack.Peek()) >= Precedence(c))
                            {
                                postfixExpression += operatorStack.Pop();
                            }
                            operatorStack.Push(c);
                            break;
                        case '^':
                            // Vyprázdnění zásobníku s operátory s prioritou menší
                            while (operatorStack.Count > 0 && Precedence(operatorStack.Peek()) > Precedence(c))
                            {
                                postfixExpression += operatorStack.Pop();
                            }
                            operatorStack.Push(c);
                            break;
                        case '√':
                            // Vyprázdnění zásobníku s operátory s prioritou menší
                            while (operatorStack.Count > 0 && Precedence(operatorStack.Peek()) > Precedence(c))
                            {
                                postfixExpression += operatorStack.Pop();
                            }
                            operatorStack.Push(c);
                            break;
                        case '!':
                            operatorStack.Push(c);
                            break;
                    }
                }
            }

            // Vyprázdnění zásobníku zbylých operátorů
            while (operatorStack.Count > 0)
            {
                postfixExpression += operatorStack.Pop();
            }

            Stack<double> operandStack = new Stack<double>();

            foreach (string token in postfixExpression.Split(' '))
            {
                if (double.TryParse(token, out double value))
                {
                    operandStack.Push(value);
                }
                else
                {
                    char op = token[0];
                    double operand2 = operandStack.Pop();

                    switch (op)
                    {
                        case '+':
                            operandStack.Push(Add(operandStack.Pop(), operand2));
                            break;
                        case '-':
                            operandStack.Push(Sub(operandStack.Pop(), operand2));
                            break;
                        case '*':
                            operandStack.Push(Mul(operandStack.Pop(), operand2));
                            break;
                        case '/':
                            operandStack.Push(Div(operandStack.Pop(), operand2));
                            break;
                        case '%':
                            operandStack.Push(Mod(operandStack.Pop() % operand2));
                            break;
                        case '^':
                            double operand1 = operandStack.Pop();
                            operandStack.Push(Pow(operand1, operand2));
                            break;
                        case '√':
                            double operand1 = operandStack.Pop();
                            operandStack.Push(Sqrt(operand1, operand2));
                            break;
                        case '!':
                            operandStack.Push(Faktorial(operandStack.Pop()));
                            break;
                        default:
                            throw new InvalidOperationException("Neznámý operátor: " + op);
                    }
                }
            }

            if (operandStack.Count != 1)
            {
                throw new InvalidOperationException("Neplatný výraz");
            }

            return operandStack.Pop();
        }

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
        void OnNumberSelection(object sender, EventArgs e)
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
            result.Text == "" + calculate(result.Text);
        }
    }
}
