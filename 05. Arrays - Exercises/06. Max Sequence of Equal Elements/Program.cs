﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int counter = 1;
            int getMax = 0;

            int endIndex = 0;
            int bestEnd = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    counter++;
                    endIndex = i + 1;
                    if (counter > getMax)
                    {
                        bestEnd = endIndex;
                        getMax = counter;
                    }
                }
                else
                {
                    counter = 1;
                    endIndex = 0;
                }
            }

            int[] result = new int[getMax];

            for (int i = 0; i < getMax; i++)
            {
                result[i] = array[bestEnd - i];
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}