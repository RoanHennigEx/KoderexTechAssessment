using System.Collections.Generic;

namespace KoderexTechAssessment.VendingMachine.Interface
{
    public interface IVendingMachine
    {
        public List<int> CalculateChange(decimal purchaseAmount, decimal tenderAmount);
    }
}
