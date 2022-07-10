﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<long> arr)
    {
        long somaMinima = 0;
        long somMaxima = 0;

        for (int i = 0; i < 2; i++)
        {
            List<long> copyArr = new List<long>(arr);

            if (i == 0)
            {
                copyArr.Remove(copyArr.Max());
                somaMinima = copyArr.Sum();
            }
            else
            {
                copyArr.Remove(copyArr.Min());
                somMaxima = copyArr.Sum();
            }

        }

        Console.Write($"{somaMinima} {somMaxima}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
