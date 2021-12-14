using System;

namespace YINI_Challenges
{
    public static class Challenge1
    {

        /// <summary>
        /// Takes in the total cost of goods and calculates the price including tax.
        /// </summary>
        /// <param name="amount">The total cost of goods without tax.</param>
        /// <param name="taxRate">The tax rate to be applied. E.g. 50% = 0.5</param>
        /// <returns>Returns the price including tax.</returns>
        public static decimal Add_Tax(decimal amount, decimal taxRate) {
            return amount * (1 + taxRate);
            //throw new NotImplementedException();

        }
        /// <summary>
        /// Takes in the rrp and returns the price after discount has been deducted.
        /// </summary>
        /// <param name="rrp">The orignal price of the product.</param>
        /// <param name="discount">The percentage off the rrp to be applied. E.g. 10% = 0.1</param>
        /// <returns>Returns the price after discount.</returns>
        public static decimal Discount(decimal rrp, decimal discount) {
            return rrp * (1 - discount);
            //throw new NotImplementedException();
        }
        /// <summary>
        /// Buy two items and get the cheapest one for half price.
        /// </summary>
        /// <param name="item1">The first item </param>
        /// <param name="item2">The second item</param>
        /// <returns>Returns total value of goods</returns>
        public static decimal Buy_One_Get_One_Half_Price(decimal item1, decimal item2) {
            if (item1 < item2) {
                return item2 + (item1 * (1 - 0.5m));
            }
            return item1 + (item2 * (1 - 0.5m));
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Calculates the sum of items within an array.
        /// </summary>
        /// <param name="amounts"></param>
        /// <returns>Returns total value of goods</returns>
        public static decimal Calculate_Total_Cost(decimal[] amounts) {
            throw new NotImplementedException();
        }
    }
}
