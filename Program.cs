/*
 * Average Array
 * Pawelski
 * 1/25/2022
 * Read over the code and run the program a few times to determine what
 * the program does. Once you know what the program does and how it works,
 * answer the questions on the activity sheet.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0, average;
            double[] numbers = { 5.6, 77, 5.3, 8.49, 50.1, 66.2 };
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            average = sum / numbers.Length;
            Console.WriteLine("The average is " + average);
        }
    }
}
