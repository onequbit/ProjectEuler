﻿using System;
using System.Collections.Generic;
using System.Text;
using CodeLibrary;
using System.Linq;

namespace ProjectEuler
{
    /// <summary>
    /// Highly divisible triangular number
    /// </summary>
    /// <remarks>
    /// The sequence of triangle numbers is generated by adding the natural numbers.
    /// So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28. 
    /// The first ten terms would be:
    /// 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
    /// Let us list the factors of the first seven triangle numbers:
    /// 1: 1
    /// 3: 1,3
    /// 6: 1,2,3,6
    /// 10: 1,2,5,10
    /// 15: 1,3,5,15
    /// 21: 1,3,7,21
    /// 28: 1,2,4,7,14,28
    /// We can see that 28 is the first triangle number to have over five divisors.
    /// What is the value of the first triangle number to have over five hundred divisors?
    /// Answer:
    /// 76576500
    /// </remarks>


    public class Problem12 : IPEProblem
    {
        public string Answer => _getOutput();

        private int _divisorLimit = 0;
        private int _number = 0;
        private int _previous = 0;
        public List<int> TriangleNumbers = new List<int> { };
                
        public Problem12()
        { }

        public Problem12(int limit)
        {            
            ShowAnswer(limit);
        }

        private string _getOutput()
        {
            int result = FindTriangleNumberByDivisors(_divisorLimit);
            return $"triangle number: {result}";
        }

        public void ShowAnswer(object problemSize)
        {
            "*Problem 12*".ToConsole();
            _divisorLimit = (int)problemSize;
            Answer.ToConsole();
        }

        public void GetNextTriangleNumber()
        {
            if (this.TriangleNumbers.Count > 0) this._previous = this.TriangleNumbers.Last();
            this._number += 1;
            this.TriangleNumbers.Add(this._number + this._previous);            
        }

        public static int[] GetTriangleNumbers(int limit)
        {
            var p = new Problem12();
            for (int i = 0; i < limit; i++)
            {
                p.GetNextTriangleNumber();
            }
            return p.TriangleNumbers.ToArray();
        }

        public static int GetTriangleNumber(int limit)
        {
            return 1.RangeTo(limit).Sum();            
        }

        public static int[] GetFactorCounts(int[] triangleNumbers)
        {
            int count = triangleNumbers.Length;
            int[] factorCount = new int[count];
            for (int i = 0; i < count; i++)
            {
                int number = triangleNumbers[i];
                var factors = number.GetFactors().AddRange(new HashSet<int> { 1, number });
                factorCount[i] = factors.Count;
            }
            return factorCount;
        }

        public static int GetFactorCount(int number)
        {
            return number.GetFactors().AddRange(new HashSet<int> { 1, number }).Count;
        }

        public static void ShowFactors(int[] numbers)
        {
            foreach (var number in numbers)
            {
                var factors = number.GetFactors().AddRange(new HashSet<int> { 1, number });
                $"{number}: ".Print(); factors.ToConsole();
            }
        }

        public static int FindTriangleNumberByDivisors(int divisors)
        {
            bool found = false;
            int number = -1;
            if (divisors == 0) return -1;
            int currentLimit = 1;
            while (!found)
            {
                int[] sequence = GetTriangleNumbers(currentLimit);
                int[] counts = GetFactorCounts(sequence);
                int maxDivisorsCount = counts.Max();
                number = sequence[counts.ToList().IndexOf(maxDivisorsCount)];
                $"number: {number}, max: {maxDivisorsCount}, limit:{currentLimit}".ToConsole();
                found = maxDivisorsCount >= divisors;
                if (found)
                {
                    number = sequence[counts.ToList().IndexOf(maxDivisorsCount)];
                }
                currentLimit += 1;
            } 
            return number;
        }

    }

}