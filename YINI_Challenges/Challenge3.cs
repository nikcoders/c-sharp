using System;
using System.Collections.Generic;
using System.Linq;

namespace YINI_Challenges
{
    public static class Challenge3
    {
        /// <summary>
        /// It has been a busy year at mountain warehouse, having made lots of sales.
        /// Management would like to know which branch made the most in revenue.
        /// For this challenge you will be given an array of sales broken down by Branch and Date.  
        /// You will need to sum all branch across multiple days and identify which branch had the highest sales overall
        /// Assume that there is only one branch with the highest total
        /// We have provided some starting code but if you know of a better method then go ahead with that
        /// </summary>
        /// <param name="sales">The array of sales items</param>
        /// <returns>The branch with the best performing sales</returns>
        public static string CalculateBestBranch(SalesItem[] sales) 
        {
            var branchSales = new Dictionary<string, decimal>();

            // Implement your code here
			for (int i = 0; i < sales.Length; i++) 
			{
				string branch = sales[i].Branch;
				if (!branchSales.ContainsKey(branch)) 
				{
					branchSales.Add(sales[i].Branch, sales[i].TotalSales);
				}
				else 
				{
					decimal addSales;
					addSales = branchSales[branch] + sales[i].TotalSales;
					branchSales[branch] =  addSales;
				}
			}
			
            // throw new NotImplementedException();

            var orderedSales = branchSales.OrderByDescending(x => x.Value);
            var firstHighest = orderedSales.First();

            return firstHighest.Key;
        }
    }

    public class SalesItem
    {
        public string Branch { get; set; }
        public decimal TotalSales { get; set; }
        public DateTime Date { get; set; }
    }
}
