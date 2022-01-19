using NUnit.Framework;
using System;
using YINI_Challenges;

namespace Unit_Tests
{
    public class Challenge_4_UnitTest
    {

        private static object[] Challenge2_StampDuty_TestCases =
        {
            new object[] { 125000m, 0m },
            new object[] { 300000m, 0m },
            new object[] { 300001m, Math.Round(1 * 0.05m, 0) },
            new object[] { 500000m, Math.Round((500000-300001) * 0.05m, 0) },
            new object[] { 925000m, Math.Round((925000m-300001) * 0.05m, 0) },
            new object[] { 925001m, Math.Round((925000m-300001) * 0.05m, 0) },
            new object[] { 1500000m, Math.Round((574999m * 0.1m) + ((925000m-300001) * 0.05m), 0) },
            new object[] { 2500000m, Math.Round(((2500000m - 1500001m ) * 0.12m) + (574999m * 0.1m) + ((925000m-300001) * 0.05m), 0) },
            new object[] { 1595000m, 100150m }
        };

        [TestCaseSource(nameof(Challenge2_StampDuty_TestCases))]
        public void Challenge2_StampDuty(decimal propertyPrice, decimal expectedResult)
        {
            var result = Challenge4.StampDuty(propertyPrice);
            Assert.AreEqual(expectedResult, result);
        }
    }
}