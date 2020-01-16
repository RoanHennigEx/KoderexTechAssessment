using System.Collections.Generic;
using System.Linq;

namespace KoderexTechAssessment.VendingMachine
{
    public abstract class VendingMachine
    {
        private List<decimal> _coinDeniminations;
        public List<decimal> CoinDenominations
        {
            get { return _coinDeniminations; }
        }

        public VendingMachine(List<decimal> coinDeniminations)
        {
            _coinDeniminations = coinDeniminations.OrderByDescending(i => i).ToList();
        }
    }
}
