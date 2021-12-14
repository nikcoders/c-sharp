using NUnit.Framework;
using YINI_Challenges;

namespace Unit_Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(10, 0.5, ExpectedResult = 15)]
        [TestCase(-10, -0.5, ExpectedResult = 15)]// test needs re-witing.
        public decimal Challenge1_AddTax(decimal amount, decimal taxRate)
        {
            return Challenge1.Add_Tax(amount, taxRate);
        }

        [TestCase(10, 0.2, ExpectedResult = 8)]
        public decimal Challenge1_Discount(decimal rrp, decimal taxRate)
        {
            return Challenge1.Discount(rrp, taxRate);
        }

        [TestCase(10, 10, ExpectedResult = 15)]
        [TestCase(10, 20, ExpectedResult = 25)]
        public decimal Buy_One_Get_One_Half_Price(decimal item1, decimal item2)
        {
            return Challenge1.Buy_One_Get_One_Half_Price(item1, item2);
        }

        

    }
}