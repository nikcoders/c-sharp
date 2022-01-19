using NUnit.Framework;
using YINI_Challenges;
using System;

namespace Unit_Tests
{
    public class Challenge_1_UnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        private static object[] Challenge1_AddTax_ShouldCalcuate_TestCases =
        {
            new object[] { 10m, 0.5m, 15m },
            new object[] { (decimal.MaxValue - 1) / 2m, 1m, decimal.MaxValue - 1 },
            new object[] { 1m, 0m, 1m },
            new object[] { 0m, 1m, 0m }
        };

        private static object[] Challenge1_AddTax_ShouldThrow_TestCases =
        {
            new object[] { decimal.MaxValue, 2m }
        };

        private static readonly object[] Challenge1_Calculate_Total_Cost_TestCases =
        {
            new object[] { new { Input = new decimal[] { 1, 2, 3, 4, 5 }, ExpectedResult = 15 } },
            new object[] { new { Input = new decimal[] { 10, 20, 30, 40, 50 }, ExpectedResult = 150 } },
            new object[] { new { Input = new decimal[] { -1, -2, -3, -4, -5 }, ExpectedResult = -15 } },
            new object[] { new { Input = new decimal[] { -1, -2, -3, -4, 5 }, ExpectedResult = -5 } }
        };

        [TestCaseSource("Challenge1_AddTax_ShouldCalcuate_TestCases")]
        public void Challenge1_AddTax_ShouldCalcuate(decimal amount, decimal taxRate, decimal expectedResult)
        {
            var result = Challenge1.Add_Tax(amount, taxRate);
            Assert.AreEqual(expectedResult, result); ;
        }

        [TestCaseSource("Challenge1_AddTax_ShouldThrow_TestCases")]
        public void Challenge1_AddTax_ShouldThrow(decimal amount, decimal taxRate)
        {
            Assert.Throws<OverflowException>(() => Challenge1.Add_Tax(amount, taxRate));
        }

        [TestCase(10, 0.2, ExpectedResult = 8)]
        [TestCase(78, 0.4, ExpectedResult = 46.8)]
        [TestCase(100, 1, ExpectedResult = -1)]
        [TestCase(100, 2, ExpectedResult = -1)]
        [TestCase(100, -1, ExpectedResult = -1)]
        public decimal Challenge1_Discount_ShouldCalculate(decimal rrp, decimal taxRate)
        {
            return Challenge1.Discount(rrp, taxRate);
        }

        [TestCase(10, 10, ExpectedResult = 15)]
        [TestCase(10, 20, ExpectedResult = 25)]
        [TestCase(20, 10, ExpectedResult = 25)]

        public decimal Buy_One_Get_One_Half_Price(decimal item1, decimal item2)
        {
            return Challenge1.Buy_One_Get_One_Half_Price(item1, item2);
        }

        [TestCaseSource(nameof(Challenge1_Calculate_Total_Cost_TestCases))]
        public void Challenge1_Calculate_Total_Cost(dynamic cases)
        {
            Assert.AreEqual(cases.ExpectedResult, Challenge1.Calculate_Total_Cost(cases.Input));
        }
    }
}
