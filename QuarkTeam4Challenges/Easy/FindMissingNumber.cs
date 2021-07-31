using System;
using System.Collections.Generic;
using System.Text;

namespace QuarkTeam4Challenges.Easy
{
    //Create a function that takes an array of numbers between 1 and 10
    //(excluding one number) and returns the missing number.
    //MissingNum([10, 5, 1, 2, 4, 6, 8, 3, 9]) ➞ 7
    public class FindMissingNumber
    {

        public static int FindMissingNumberMethod(int[] numbers)
        {
            List<int> numbersList = new List<int>(numbers);
            numbersList.Sort();
            int left = 0, right = numbers.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                // If the middle element is not on
                // the middle index, then the missing element is mid + 1.
                if (numbersList[mid] != mid + 1 && numbersList[mid - 1] == mid)
                    return mid + 1;

                // This case means that the missing element is
                // not to the left. So search the right.
                if (numbersList[mid] == mid + 1)
                    left = mid - 1;

                // This case means that the missing element is not
                // to the right. So search the left.
                else
                    left = mid + 1;
            }

            return -1;
        }


    }
}
