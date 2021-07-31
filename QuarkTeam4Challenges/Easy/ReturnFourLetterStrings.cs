using System;
using System.Collections.Generic;
using System.Text;

namespace QuarkTeam4Challenges.Easy
{
    //Create a function that takes an array of strings and returns the words that are
    //exactly four letters.


    public class ReturnFourLetterStrings
    {

        public static string[] FourLetterStrings( string[] words)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == 4)
                    result.Add(words[i]);
            }
            var a = result.ToArray();
            return a;
        }

    }
}
