using NUnit.Framework;
using YINI_Challenges;

namespace Unit_Tests
{
    public class Challenge_2_UnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(125000, ExpectedResult = 0)]
        [TestCase(295000, ExpectedResult = 4750)]
        public decimal Challenge2_StampDuty(decimal propertyPrice)
        {
            return Challenge2.StampDuty(propertyPrice);
        }       

    }
}