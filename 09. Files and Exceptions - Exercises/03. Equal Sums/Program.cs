﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tests = File.ReadAllLines("../../InputOutput/Input.txt");
            string[] result = new string[tests.Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = $"Test {i + 1}: {tests[i]}{Environment.NewLine}Output: {EqualSum(tests[i].Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray())}";
            }

            File.WriteAllLines("../../InputOutput/Output.txt", result);
        }

        private static string EqualSum(int[] numbers)
        {
            if (numbers.Length == 1)
            {
                return 0.ToString();
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int leftSum = numbers.Take(i).Sum();
                int rightSum = 0;
                for (int j = numbers.Length - 1; j > i; j--)
                {
                    rightSum += numbers[j];
                    if (leftSum == rightSum)
                    {
                        return i.ToString();
                    }
                }
            }

            return "no";
        }
    }
}