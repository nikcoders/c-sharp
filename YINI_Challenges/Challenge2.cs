using System;

namespace YINI_Challenges
{
    public static class Challenge2
    {
        /// <summary>
        /// During your time at mountain warheouse you will often have to go bug fix your own (and other peoples!) code.
        /// The following method should return the smallest value in the given array. If the array is empty then it should return 0.
        /// However, the last dev has made some bugs.  It seems it only works when the number "1" is the smallest value in the array - for all other cases the method fails
        /// 4 bugs have been identified within the code.
        /// See if you can find them all! 
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int ReturnSmallestValueInArray(int[] numbers)
        {
            // int min = int.MinValue;
            int min = int.MaxValue;
			// for (int i = 0; i > numbers.Length; i++)
			for (int i = 0; i < numbers.Length; i++)
            {
                // if (min < numbers[i])
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }
            return min;
			// return 1;
        }
    }
}
