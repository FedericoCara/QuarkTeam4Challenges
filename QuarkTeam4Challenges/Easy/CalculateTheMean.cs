using System;
using System.Collections.Generic;
using System.Text;

namespace QuarkTeam4Challenges.Easy
{
    /*
     * Create a function that takes an array of numbers and returns the mean (average) of all those numbers.
     * Mean([1, 0, 4, 5, 2, 4, 1, 2, 3, 3, 3]) ➞ 2.55
     */
    public class CalculateTheMean
    {
        public static double Calculate(int[] numbers)
        {
            float result = 0.0f;

            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }

            result = result / numbers.Length;

            return Math.Round(result, 2);
        }

    }
}


//[TestCase(new int[] { 1, 0, 4, 5, 2, 4, 1, 2, 3, 3, 3 }, Result = 2.55)]
//[TestCase(new int[] { 324, 543, 654, 9876 }, Result = 2849.25)]
//[TestCase(new int[] { 0, 0, 0, 0 }, Result = 0.0)]
//[TestCase(new int[] { 30, 40, 20, 100, 30 }, Result = 44.0)]
//[TestCase(new int[] { 1, 1, 1, 0 }, Result = 0.75)]
//[TestCase(new int[] { 1, 1, 0, 1, 2, 1, 1, 1, 0, 0 }, Result = 0.8)]
//[TestCase(new int[] { 10000 }, Result = 10000.0)] 

//Test Results
//FixedTest
//Test Passed
//Completed in: 0.017795
//FixedTest
//Test Passed
//Completed in: 0.000271
//FixedTest
//Test Passed
//Completed in: 0.000109
//FixedTest
//Test Passed
//Completed in: 9.2E-05
//FixedTest
//Test Passed
//Completed in: 9.3E-05
//FixedTest
//Test Passed
//Completed in: 9.3E-05
//FixedTest
//Test Passed
//Completed in: 0.00011