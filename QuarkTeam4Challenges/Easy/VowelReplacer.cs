using System;
using System.Collections.Generic;
using System.Text;

namespace QuarkTeam4Challenges.Easy
{
    // Create a function that replaces all the vowels
    // in a string with a specified character.
    // ReplaceVowels("the aardvark", '#') ➞ "th# ##rdv#rk"
    public class VowelReplacer
    {
        public static string VowelReplacerMethod(string words, char replacer)
        {
            var charResult = words.ToLower().ToCharArray();
            for (int i = 0; i < charResult.Length; i++)
            {
                if (charResult[i] == 'a' || charResult[i] == 'e' || charResult[i] == 'i'
                    || charResult[i] == 'o' || charResult[i] == 'u')
                {
                    charResult[i] = replacer;
                }
            }

            string result = new string(charResult);

            return result;
        }

    }
}
