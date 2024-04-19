using System;
using System.Collections.Generic;

namespace SplittheBillLibrary;

    public class CalculateWeight
    {
        public Dictionary<string, decimal> CalculateAverage(Dictionary<string, decimal> mealCosts, float tipPercentage)
        {
            Dictionary<string, decimal> tipAmounts = new Dictionary<string, decimal>();

            decimal totalCost = 0;
            foreach (var cost in mealCosts.Values)
            { 
                totalCost += cost;
            }

            foreach (var kvp in mealCosts)
            {
                decimal individualTip = kvp.Value * (decimal)(tipPercentage / 100);
                tipAmounts.Add(kvp.Key, individualTip);
            }

            return tipAmounts;
        }

        public decimal CalculateTipPerPerson(decimal price, int numberOfPatrons, float tipPercentage)
        {
            if (numberOfPatrons <= 0)
            {
                throw new ArgumentException("Number of patrons must be greater than zero.", nameof(numberOfPatrons));
            }

            decimal totalTip = price * (decimal)(tipPercentage / 100);
            decimal tipPerPerson = totalTip / numberOfPatrons;

            return tipPerPerson;
        }
    }
