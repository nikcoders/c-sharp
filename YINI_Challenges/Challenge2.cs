using System;

namespace YINI_Challenges
{
    public static class Challenge2
    {
       
        /// <summary>
        /// For this task you will have to calculate and return the stamp duty of a property you have purchased.
        /// Stamp duty is a type of tax applied by the UK goverment when you purchase a property, this tax works in price brackets.
        /// i.e the same way income tax does.
        /// Up to £125,000 there is 0% tax.
        /// £125,000.001 - £250,000 there is 2% tax.
        /// £250,000.001 - £925,000 there is 5% tax.
        /// £925,000.001 - £1,500,000 there is 10% tax.
        /// £1,500,000.001+ there is 12% tax
        /// For example if you buy a house worth £295,000:
        /// 0% on the first £125,000 = £0
        /// 2% on the next £125,000 = £2,500
        /// 5% on £45,00 remaining = £2,250
        /// Total tax = £4,750
        /// </summary>
        /// <param name="propertyPrice">The price of the property purchased</param>
        /// <returns>Total stamp duty</returns>
        public static decimal StampDuty(decimal propertyPrice)
        { 
            throw new NotImplementedException(); 
        }

        //This is likely the longest/hardest challenge so will move this challenge to be last or second to last.
    }
}

