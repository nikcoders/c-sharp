using NUnit.Framework;
using YINI_Challenges;

namespace Unit_Tests
{
    public class Challenge_3_UnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Challenge3_Bugfix_1()
        {
            int[] numbers = { 1, 2, 3, 4 };
            int min = Challenge3.bugfix(numbers);
            Assert.AreEqual(1, min);
        }

        [Test]
        public void Challenge3_Bugfix_2()
        {
            int[] numbers = { 1, 2, -3, 4 };
            int min = Challenge3.bugfix(numbers);
            Assert.AreEqual(-3, min);
        }

        [Test]
        public void Challenge3_Bugfix_3()
        {
            int[] numbers = { 1, 2, -3, 4, 5, -99, 100000, -92 };
            int min = Challenge3.bugfix(numbers);
            Assert.AreEqual(-99, min);
        }

    }
}