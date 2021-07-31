using QuarkTeam4Challenges.Easy;
using QuarkTeam4Challenges.Expert;
using QuarkTeam4Challenges.VeryDificult;
using System;

namespace QuarkTeam4Challenges
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //SimplifiedFractions fractions = new SimplifiedFractions();

            //Console.WriteLine(fractions.Simplify("300/300"));
            //Console.WriteLine(fractions.Simplify("600/300"));
            //Console.WriteLine(fractions.Simplify("8/4"));
            //Console.WriteLine(fractions.Simplify("5/7"));
            //Console.WriteLine(fractions.Simplify("5136524/712345"));

            //Console.WriteLine("----------------------------------------------");

            //KnightsBoard knights = new KnightsBoard();

            //bool resultChess = knights.CannotCapture(new int[,] {
            //    { 0, 0, 0, 1, 0, 0, 0, 0 },
            //    { 0, 0, 0, 0, 0, 0, 0, 0 },
            //    { 0, 1, 0, 0, 0, 1, 0, 0 },
            //    { 0, 0, 0, 0, 1, 0, 1, 0 },
            //    { 0, 1, 0, 0, 0, 1, 0, 0 },
            //    { 0, 0, 0, 0, 0, 0, 0, 0 },
            //    { 0, 1, 0, 0, 0, 0, 0, 1 },
            //    { 0, 0, 0, 0, 1, 0, 0, 0 }
            //});
            //Console.WriteLine($"Chess: {resultChess}");

            //bool resultChess1 = knights.CannotCapture(new int[,] {
            //    {1, 0, 1, 0, 1, 0, 1, 0},
            //    {0, 1, 0, 1, 0, 1, 0, 1},
            //    {1, 0, 1, 0, 1, 0, 1, 0},
            //    {0, 0, 0, 1, 0, 1, 0, 1},
            //    {1, 0, 0, 0, 1, 0, 1, 0},
            //    {0, 0, 0, 0, 0, 1, 0, 1},
            //    {1, 0, 1, 0, 1, 0, 1, 0},
            //    {1, 0, 0, 1, 0, 0, 0, 1}
            //});
            //Console.WriteLine($"Chess: {resultChess1}");

            //Console.WriteLine("----------------------------------------------");

            //var resultGrid = PrintGrid.PrintGridResult(3,6);
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 6; j++)
            //    {
            //        Console.Write(resultGrid[i,j]+ " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("----------------------------------------------");

            //Console.WriteLine("Roman Numerals");
            //Console.WriteLine(RomanNumerals.ParseRomanNumeral("XXIX"));
            //Console.WriteLine(RomanNumerals.ParseRomanNumeral("CMXCIX"));
            //Console.WriteLine(RomanNumerals.ParseRomanNumeral("MMMDCCCLXXXVIII"));

            //Console.WriteLine("----------------------------------------------");

            //Console.WriteLine("Binary Clock");
            //BuildingBinaryClock.BinaryClock("10:37:49");


            Console.WriteLine("----------------------------------------------");

            var result = VowelReplacer.VowelReplacerMethod("the aardvark", '#');


        }
    }

}
