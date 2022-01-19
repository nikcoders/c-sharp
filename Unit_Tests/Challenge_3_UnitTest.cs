using NUnit.Framework;
using System;
using YINI_Challenges;

namespace Unit_Tests
{
    public class Challenge_3_UnitTest
    {
        private static object[] Challenge3_CalculateBestBranch_TestCases =
        {
            new object[]
            {
                new SalesItem[]
                {
                    new SalesItem{ Branch = "ABC", TotalSales = 100, Date = DateTime.Today },
                    new SalesItem{ Branch = "ABC", TotalSales = 50, Date = DateTime.Today.AddDays(-1) },
                    new SalesItem{ Branch = "ABC", TotalSales = 400, Date = DateTime.Today.AddDays(-2) },
                    new SalesItem{ Branch = "DEF", TotalSales = 200, Date = DateTime.Today }
                }, "ABC"
            },
            new object[]
            {
                new SalesItem[]
                {
                    new SalesItem{ Branch = "ABC", TotalSales = 100, Date = DateTime.Today },
                    new SalesItem{ Branch = "ABC", TotalSales = 50, Date = DateTime.Today.AddDays(-1) },
                    new SalesItem{ Branch = "ABC", TotalSales = 200, Date = DateTime.Today.AddDays(-2) },
                    new SalesItem{ Branch = "DEF", TotalSales = 500, Date = DateTime.Today }
                }, "DEF"
            }
        };

        [TestCaseSource(nameof(Challenge3_CalculateBestBranch_TestCases))]
        public void Challenge3_CalculateBestMonth(SalesItem[] itemList,string expectedResult)
        {
            Assert.AreEqual(expectedResult, Challenge3.CalculateBestBranch(itemList));
        }
    }

    
}