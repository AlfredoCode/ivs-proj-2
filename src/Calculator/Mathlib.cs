using System;
using exeptions;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;

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
            return num2 - num1;
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
            if (num1 == 0.0)
            {
                throw new DivZeroException("Division by zero is not possible.");
            }
            return num2 / num1;
        }


        /// <summary>
        /// Function to modulo
        /// throws exeption if we do modulo by 0
        /// <summary>
        public static double Mod(double num2, double num1)
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
        public static double Pow(double num2, double num1)
        {
            if (num2 < 0 || num2 % 1 != 0)
            {
                throw new PowNaturalException("Power have to be natural number.");
            }
            else if (num1 == 0 || num2 == 0)
            {
                return 1;
            }
            else
            {
                double j = num1;
                for (int i = 0; i < num2 - 1; i++)
                {
                    num1 *= j;
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
            }
            else if (num1 < 0)
            {
                throw new SqrtNegExeption("Negative numbers cant be square rooted.");
            }
            else if (num2 == 0)
            {
                throw new SqrtbyZeroExeption("Infinity.");
            }
            double x0 = num1 / 2; // Počáteční odhad
            double x1 = (1 / num2) * ((num2 - 1) * x0 + (num1 / Math.Pow(x0, num2 - 1))); // Newtonova iterace

            while (Math.Abs(x1 - x0) >= 0.0001)
            {
                x0 = x1;
                x1 = (1 / num2) * ((num2 - 1) * x0 + (num1 / Math.Pow(x0, num2 - 1))); // Newtonova iterace
            }
            return x1;
        }
        /// <summary>
        /// Function to faktorial
        /// throws exeption if we do faktorial by negative number
        /// <summary>
        public static int Faktorial(double num1)
        {
            // Convert the double value to int
            int intValue = (int)num1;

            if (intValue < 0)
            {
                throw new FactorialExeption("Negative number is not allowed in faktorial.");
            }else
            {
                int j = 1;
                for (int i = 2; i <= intValue; i++)
                {
                    j *= i;
                }
                return j;
            }
        }
        public static string ridoff0(string s)
        {
            if (s.Length == 2 && s[0] == '0')
            {
                s = s.TrimStart('0');
                return s;
            }
            else
            {
                return s;
            }

        }

        private static int Precedence(string op)
        {
            switch (op)
            {
                case "+":
                case "-":
                    return 1;
                case "*":
                case "/":
                case "%":
                    return 2;
                case "^":
                case "√":
                case "!":
                    return 3;
                default:
                    throw new ArgumentException("Invalid operator");
            }
        }

        public static string calculate(string infixExpression)
        {
            // Zásobník pro operátory
            Stack<string> operatorStack = new Stack<string>();

            // Výstupní postfixový řetězec
            string postfixExpression = "";
            var tokens = Regex.Matches(infixExpression, @"(?:\d+\.\d+)|(?:\d+)|(?:\d+\,\d+)|[()+\-*\/^√%!]|π|R");

            // Procházení infixového výrazu
            foreach (Match match in tokens)
            {
                string token = match.Value;

                // Operandy
                if (char.IsLetterOrDigit(token[0]) || token == "π" || token == "R")
                {
                    postfixExpression += token + " ";
                }
                // Operátory a závorky
                else
                {
                    switch (token[0])
                    {
                        case '+':
                        case '-':
                            // Vyprázdnění zásobníku s operátory s nižší prioritou
                            while (operatorStack.Count > 0 && Precedence(operatorStack.Peek()) >= Precedence(token))
                            {
                                postfixExpression += operatorStack.Pop() + " ";
                            }
                            operatorStack.Push(token);
                            break;
                        case '*':
                        case '/':
                        case '%':
                            // Vyprázdnění zásobníku s operátory s prioritou menší nebo rovnou
                            while (operatorStack.Count > 0 && Precedence(operatorStack.Peek()) >= Precedence(token))
                            {
                                postfixExpression += operatorStack.Pop() + " ";
                            }
                            operatorStack.Push(token);
                            break;
                        case '^':
                        case '√':
                        case '!':
                            // Vyprázdnění zásobníku s operátory s prioritou menší
                            while (operatorStack.Count > 0 && Precedence(operatorStack.Peek()) > Precedence(token))
                            {
                                postfixExpression += operatorStack.Pop() + " ";
                            }
                            operatorStack.Push(token);
                            break;
                    }
                }
            }

            // Vyprázdnění zásobníku zbylých operátorů
            while (operatorStack.Count > 0)
            {
                postfixExpression += operatorStack.Pop() + " ";
            }

            Stack<double> operandStack = new Stack<double>();
            System.Diagnostics.Debug.WriteLine(postfixExpression);
            foreach (string token in postfixExpression.Split(' '))
            {
                if (!string.IsNullOrEmpty(token))  // Add this line to check if token is not empty
                {
                    if (double.TryParse(token, out double value))
                    {
                        operandStack.Push(value);
                    }
                    else
                    {
                        char op = token[0];

                        switch (op)
                        {
                            case '+':
                                operandStack.Push(Add(operandStack.Pop(), operandStack.Pop()));
                                break;
                            case '-':
                                operandStack.Push(Sub(operandStack.Pop(), operandStack.Pop()));
                                break;
                            case '*':
                                operandStack.Push(Mul(operandStack.Pop(), operandStack.Pop()));
                                break;
                            case '/':
                                operandStack.Push(Div(operandStack.Pop(), operandStack.Pop()));
                                break;
                            case '%':
                                operandStack.Push(Mod(operandStack.Pop(), operandStack.Pop()));
                                break;
                            case '^':
                                operandStack.Push(Pow(operandStack.Pop(), operandStack.Pop()));
                                break;
                            case '√':
                                operandStack.Push(Sqrt(operandStack.Pop(), operandStack.Pop()));
                                break;
                            case '!':
                                operandStack.Push(Faktorial(operandStack.Pop()));
                                break;
                            case 'π':
                                operandStack.Push(3.14159265359);
                                break;
                            case 'R':
                                Random random = new Random();
                                operandStack.Push(random.Next(101));
                                break;
                            default:
                                throw new InvalidOperationException("Neznámý operátor: " + op);
                        }
                    }
                }
            }
            foreach (var operand in operandStack) {
                System.Diagnostics.Debug.WriteLine(operand);
            }
            if (operandStack.Count != 1)
            {
                throw new InvalidOperationException("Neplatný výraz");
            }

            return operandStack.Pop().ToString();
        }
    }
}