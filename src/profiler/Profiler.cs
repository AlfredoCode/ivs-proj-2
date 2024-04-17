/// <summary>
/// Profiler.cs
/// 
/// Dominik Hofman (xhofma11)
///
/// Implementation of Profiler.version 0.1
/// Last update 2024-03-28
/// <summary>
using System;
using System.Collections.Generic;
using Mathlib;


namespace Profiler
{
    public class Profiler
    {
        /// <summary>
        /// Reads standard input from the console and parses it into list of doubles
        /// Removes whitespace characters from the input
        /// </summary>
        /// <returns>A list of doubles parsed from the console input.</returns>
        public static List<double> StdinParser()
        {
            List<double> numbersOnly = new List<double>();

            using (var reader = new StreamReader(Console.OpenStandardInput()))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] tokens = line.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string token in tokens)
                    {
                        if (double.TryParse(token.Replace(".",","), out double parsedNum))
                        {
                            numbersOnly.Add(parsedNum);
                        }
                    }
                }
            }

            return numbersOnly;
        }
        public static void CalculateDeviation(List<double> numbers)
        {
            if(numbers.Count <= 1)
            {
                Console.WriteLine("0");
                return;
            }
            int count = numbers.Count;
            double sum = 0.0;
            double sumQuares = 0.0;

            foreach (double num in numbers)
            {
                sum = Operations.Add(sum, num);                   // Sum ((x_i))
                sumQuares = Operations.Add(sumQuares, Operations.Pow(2, num)); // Sum( (x_i)^2 )
                
            }
            double avg = Operations.Div(count, sum);
            double avgSquared = Operations.Mul(avg, avg);   // (x')^2
            double variance = Operations.Div(Operations.Sub(1, count), Operations.Sub(Operations.Mul(count, avgSquared), sumQuares)); // (Sum(x_i)^2) - (N * (x')^2) / (N - 1)
            double s = Operations.Sqrt(variance, 2);    // sqrt((Sum(x_i)^2) - (N * (x')^2) / (N - 1))

            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            List<double> numbersOnly = StdinParser();
            CalculateDeviation(numbersOnly);
            return;

        }

    }
};