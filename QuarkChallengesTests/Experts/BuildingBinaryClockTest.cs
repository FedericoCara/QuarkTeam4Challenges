﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QuarkTeam4Challenges.Experts
{
    /* https://edabit.com/challenge/DZL7PpHQyPvkYiyDL
     * A binary clock displays the time of day in binary format. 
     * Modern binary clocks have six columns of lights; two for each of the hours, minutes and seconds. 
     * The photo below shows a binary clock displaying the time "12:15:45":
     */

    [TestClass]
    public class BuildingBinaryClockTest
    {

        [TestMethod]
        public void TestBinaryClock() 
        {
            var correctResult = new string[] { " 0 0 0", " 00101", "000101", "101011" };
            string time = "10:37:49";
            Console.WriteLine($"Input: {time}");

            var result = BuildingBinaryClock.BinaryClock("10:16:17");

            Assert.Equals(result, correctResult);
        }
        
    }
}
