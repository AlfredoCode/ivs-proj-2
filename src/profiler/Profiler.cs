/// <summary>
/// Profiler.cs
/// 
/// Dominik Hofman (xhofma11)
///
/// Implementation of Profiler.version 0.2
/// Last update 2024-04-18
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
            // List to store parsed numbers
            List<double> numbersOnly = new List<double>();

            // Open standard input for reading
            using (var reader = new StreamReader(Console.OpenStandardInput()))
            {
                string line;
                // Read each line from the input until there are no more lines
                while ((line = reader.ReadLine()) != null)
                {
                    // Variables to track the start and end indices of each token
                    int startIndex = -1;
                    int endIndex = 0;

                    // Loop through each character in the current line
                    for (int i = 0; i < line.Length; i++)
                    {
                        // Check if the character is not a whitespace
                        if (!char.IsWhiteSpace(line[i]))
                        {
                            // If startIndex is -1, set it to the current index
                            if (startIndex == -1)
                            {
                                startIndex = i;
                            }
                        }
                        else
                        {
                            // If startIndex is not -1 and a whitespace is encountered,
                            // extract the token and add it to the numbersOnly list
                            if (startIndex != -1)
                            {
                                string token = line.Substring(startIndex, endIndex - startIndex);
                                // Parse the token into a double and add it to the list
                                if (double.TryParse(token.Replace(".", ","), out double parsedNum))
                                {
                                    numbersOnly.Add(parsedNum);
                                }
                                // Reset startIndex for the next token
                                startIndex = -1;
                            }
                        }
                        // Increment endIndex to move to the next character
                        endIndex++;
                    }

                    // Add the last token if it exists after the loop ends
                    if (startIndex != -1)
                    {
                        string token = line.Substring(startIndex, endIndex - startIndex);
                        // Parse the last token into a double and add it to the list
                        if (double.TryParse(token.Replace(".", ","), out double parsedNum))
                        {
                            numbersOnly.Add(parsedNum);
                        }
                    }
                }
            }

            // Return the list of parsed numbers
            return numbersOnly;
        }
        /// <summary>
        /// Calculates the standard deviation of a list of numbers.
        /// </summary>
        /// <param name="numbers">The list of numbers.</param>
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