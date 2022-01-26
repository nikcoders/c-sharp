using System;
using System.Linq;

namespace YINI_Challenges
{
    public static class Challenge1
    {

        /// <summary>
        /// Receives an amount and returns the total amount including tax.
        /// </summary>
        /// <param name="nonTaxAmount">The total cost of goods without tax.</param>
        /// <param name="taxRate">The tax rate to be applied. 50% = 0.5</param>
        /// <returns>Returns the price including tax.</returns>
        public static decimal Add_Tax(decimal nonTaxAmount, decimal taxRate)
        {
            return nonTaxAmount + (nonTaxAmount * taxRate);
        }

        /// <summary>
        /// Takes in the current price and returns the price after discount has been deducted.
        /// If the discount value is not valid then this method should return -1
        /// </summary>
        /// <param name="currentPrice">The current price of the product.</param>
        /// <param name="discount">The percentage off of the rrp to be applied. E.g. 10% = 0.1</param>
        /// <returns>Returns the price after discount.</returns>
        public static decimal Discount(decimal currentPrice, decimal discount)
        {
            if (discount >= 1 || discount < 0)
            {
                return -1;
            }

            return currentPrice - (currentPrice * discount);
        }

        /// <summary>
        /// Calculate the total price where two items are part of a "Buy One Get One Half Price" promotion.
        /// </summary>
        /// <param name="item1">The first item </param>
        /// <param name="item2">The second item</param>
        /// <returns>Returns total value of goods</returns>
        public static decimal Buy_One_Get_One_Half_Price(decimal item1, decimal item2)
        {
            decimal cheapestPrice = item1 > item2 ? item2 : item1; // The cheapest of the two items
            return cheapestPrice / 2 + (cheapestPrice == item1 ? item2 : item1); // Adds half off the cheapest item to whatever the other item is
        }

        /// <summary>
        /// Calculates the sum of items within an array.
        /// </summary>
        /// <param name="amounts"></param>
        /// <returns>Returns total value of goods</returns>
        public static decimal Calculate_Total_Cost(decimal[] amounts)
        {
            //return amounts.Sum(); //If LinQ is allowed?

            int sum = 0;
            foreach(int amount in amounts)
            {
                sum += amount;
            }
            return sum;
        }
    }
}