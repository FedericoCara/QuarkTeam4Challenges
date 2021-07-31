using System;
using System.Collections.Generic;
using System.Text;

namespace QuarkTeam4Challenges.Experts
{
    /*
     * Create a function that takes in a Roman numeral as a string and converts it to an integer, returning the result. 
     * The function should work for all Roman numerals representing positive integers less than 4000.
     * 
     * I-> 1        IV -> 4
     * V -> 5       IX -> 9
     * X -> 10      XL -> 40
     * L -> 50      XC -> 90
     * C -> 100     CD -> 400
     * D -> 500     CM -> 900
     * M -> 1000
     * 
           // http://csharphelper.com/blog/2016/04/convert-to-and-from-roman-numerals-in-c/

     */
    public class RomanNumerals
    {
        public static int ParseRomanNumeral(string num)
        {
            var romanos = new Dictionary<char, int> {
                ['I'] = 1,
                ['V'] = 5,    
                ['X'] = 10,       
                ['L'] = 50,       
                ['C'] = 100,
                ['D'] = 500,
                ['M'] = 1000
            };

            int total = 0, last = 0, current = 0;

            for (int i = num.Length - 1; i >= 0; i--) {
                current = romanos[num[i]];
                if (current < last) {
                    total -= current;
                } else {
                    total += current;
                    last = current;
                }
            }

            return total;
        }

    }
}

//Estimado: 30 minutos
//Reales: 40 minutos
//Integrantes: Equipo 4

/*
 * [TestFixture]
 public class Tests
 {
     [TestCase("I", Result=1)]
     [TestCase("VIII", Result=8)]
     [TestCase("XXIX", Result=29)]
     [TestCase("LIV", Result=54)]
     [TestCase("CCV", Result=205)]
     [TestCase("CDXLIV", Result=444)]
     [TestCase("CMXCIX", Result=999)]
     [TestCase("M", Result=1000)]
     [TestCase("MMMDCCCLXXXVIII", Result=3888)]
     [TestCase("MMMCMX", Result=3910)]
     public static int TestSolution(string num)
     {
         return Program.ParseRomanNumeral(num);
     }
 }
 */
