using NUnit.Framework;
using YINI_Challenges;

namespace Unit_Tests
{
    public class Challenge_2_UnitTest
    {
        private static object[] Challenge3_TestCases =
        {
            new object[] { new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 1 },
            new object[] { new int[] { 1, 2, -3, 4 } , -3 },
            new object[] { new int[] { int.MinValue, int.MinValue, 1, 2, -3, 4 } , int.MinValue },
            new object[] { new int[] { 0, 0, 0, 0, 0 } , 0 },
            new object[] { new int[] { int.MaxValue } , int.MaxValue },
            new object[] { new int[] {  } , 0 },
            new object[] { new int[] { int.MaxValue -1 } , int.MaxValue - 1 },
        };

        [TestCaseSource(nameof(Challenge3_TestCases))]
        public void Challenge2_ReturnSmallestValueInArray_ShouldReturnValidValue(int[] numbers, int expectedResult)
        {
            Assert.AreEqual(expectedResult, Challenge2.ReturnSmallestValueInArray(numbers));
        }
    }
}