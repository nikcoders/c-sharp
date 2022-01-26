using System;

namespace YINI_Challenges
{
    public static class Challenge4
    {

        /// <summary>
        /// For this task you will have to calculate and return the stamp duty of a property you have purchased.
        /// Stamp duty is a type of tax applied by the UK goverment when you purchase a property, this tax works in price brackets.
        /// i.e the same way income tax does.
        /// Less than £300,000 there is 0% tax.
        /// £300,001 - £925,000 there is 5% tax.
        /// £925,001 - £1,500,000 there is 10% tax.
        /// £1,500,001+ there is 12% tax
        /// All amounts as each tax bracket is calculated is rounded to the nearest pound
        /// 
        /// For example if you buy a house worth £1,595,000:
        /// 0% on the first £300,000 = £0
        /// 5% on £624,999 (£300,001 -> £925,000) = £31,250
        /// 10% on £574,999 (£1,500,000 - £925,001) = £57,500
        /// 12% on the remaining £94,999 (£1,595,000 - £1,500,001) = £11,400
        /// Total tax = £100,150
        /// </summary>
        /// <param name="propertyPrice">The price of the property purchased</param>
        /// <returns>Total stamp duty</returns>
        public static decimal StampDuty(decimal propertyPrice)
        {
            if (propertyPrice <= 300001) 
                return 0;

            decimal tax = 0m;

            decimal taxBracket12 = 1500001m;
            decimal taxBracket10 = 925001m;
            decimal taxBracket5 = 300001m;


            if (propertyPrice >= taxBracket12)
            {
                tax += Math.Round(((propertyPrice - taxBracket12) * 0.12m));
            }

            if (propertyPrice >= taxBracket10)
            {
                tax += Math.Round((Math.Min(taxBracket12 - 1m, propertyPrice) - taxBracket10) * 0.1m);
            }

            if (propertyPrice >= taxBracket5)
            {
                tax += Math.Round((Math.Min(taxBracket10 - 1m, propertyPrice) - taxBracket5) * 0.05m);
            }

            return Math.Round(tax, 0);
        }
    }
}

