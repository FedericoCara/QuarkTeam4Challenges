using System.Collections.Generic;

namespace QuarkTeam4Challenges.VeryDificult
{
    public class MaximumOcurrence
    {
        public const string NO_REPETITION = "No Repetition";

        public static string MaxOccur(string givenString) {
            Dictionary<char, int> ocurrencesDict = new Dictionary<char, int>();
            int maxOcurrence = 0;
            List<char> maxOcurrenceLetter = new List<char>();

            foreach (char letter in givenString) {
                SumOcurrenceCount(ocurrencesDict, letter);
                maxOcurrence = UpdateMaxOcurrences(ocurrencesDict, maxOcurrence, maxOcurrenceLetter, letter);
            }

            maxOcurrenceLetter.Reverse();
            return maxOcurrence <= 1 ? NO_REPETITION : string.Join(", ", maxOcurrenceLetter);
        }

        private static void SumOcurrenceCount(Dictionary<char, int> ocurrencesDict, char letter) {
            if (ocurrencesDict.ContainsKey(letter)) {
                ocurrencesDict[letter]++;
            } else {
                ocurrencesDict.Add(letter, 1);
            }
        }

        private static int UpdateMaxOcurrences(Dictionary<char, int> ocurrencesDict, int maxOcurrence, List<char> maxOcurrenceLetter, char letter) {
            if (ocurrencesDict[letter] > maxOcurrence) {
                maxOcurrenceLetter.Clear();
                maxOcurrenceLetter.Add(letter);
                maxOcurrence = ocurrencesDict[letter];
            } else if (ocurrencesDict[letter] == maxOcurrence) {
                maxOcurrenceLetter.Add(letter);
            }

            return maxOcurrence;
        }
    }
}
