﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalcOperations
    {
        public static double Sum(double[] nums) => nums.Sum(x => x);

        public static double Subtract(double[] nums) => nums.Aggregate((acc, x) => acc - x);

        public static double Divide(double[] nums) => nums.Aggregate((acc, x) => acc / x);

        public static double Multiply(double[] nums) => nums.Aggregate((acc, x) => acc * x);
    }
}
