namespace SplitthebillLibrary;
public class SplittheBill
    {
        public decimal SplitBill(decimal amount, int nOfPeople)
        {
            if (nOfPeople <= 0)
            {
                throw new ArgumentException("Number of people must be greater than zero.", nameof(nOfPeople));
            }

            return amount / nOfPeople;
        }
    }