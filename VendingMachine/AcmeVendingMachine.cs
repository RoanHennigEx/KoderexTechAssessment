using KoderexTechAssessment.VendingMachine.Interface;
using System.Collections.Generic;
using System.Linq;

namespace KoderexTechAssessment.VendingMachine
{
    public  class AcmeVendingMachine : VendingMachine , IVendingMachine
    {
        public AcmeVendingMachine(List<decimal> coinDeniminations) : base(coinDeniminations)
        {

        }

        public List<int> CalculateChange(decimal purchaseAmount, decimal tenderAmount)
        {
            var remainder = tenderAmount - purchaseAmount;
            List<int> change = new List<int>();

            while(remainder > 0)
            {
                foreach(var coin in CoinDenominations)
                {
                    if (remainder / coin > 0)
                    {
                        remainder -= coin;
                        change.Add((int)(coin * 100));
                    }
                }
            }

            return change.OrderByDescending(i  => i).ToList();
        }
    }
}
