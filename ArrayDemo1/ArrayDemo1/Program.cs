﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] payRate = { 6.00, 7.35, 8.12, 12.45 };
            for(int x = 3; x < payRate.Length; --x)
            {
                Console.WriteLine("pay rate {0} is {1}", x, payRate[x].ToString("C"));
            }
        }
    }
}
