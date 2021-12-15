using System;

namespace YINI_Challenges
{
    public static class Challenge3
    {
        /// <summary>
        /// During your time at mountain warheouse you will often have to go bug fix your own (and other peoples!) code.
        /// In this next challenge a min sort has been written, however there are 3 bugs within the code.
        /// See if you can find them all! 
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int bugfix(int[] numbers){
            int min = -999999999;
            for (int i = 0; i > numbers.Length; i++)
            {
                if (min < numbers[i])
                {
                    min = numbers[i];
                }
            }
            throw new NotImplementedException();
        }
    }
}
