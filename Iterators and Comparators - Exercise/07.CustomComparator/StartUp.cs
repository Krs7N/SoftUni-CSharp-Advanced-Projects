﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CustomComparator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Func<int, int, int> customComparer = (x, y) =>
            {
                if (x % 2 == 0 && y % 2 != 0)
                {
                    return -1;
                }

                if (x % 2 != 0 && y % 2 == 0)
                {
                    return 1;
                }

                return x.CompareTo(y);
            };

            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Array.Sort(numbers, (x, y) => customComparer(x, y));

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}