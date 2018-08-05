﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest3Numbers_04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Console.WriteLine(string.Join(" ", nums.OrderByDescending(x => x).Take(3)));
        }
    }
}
