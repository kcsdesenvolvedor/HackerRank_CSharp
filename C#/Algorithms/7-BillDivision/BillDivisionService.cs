using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.BillDivision
{
    public static class BillDivisionService
    {
        public static string Start(List<int> consumedFoods, int uneatenFoodIndex, int amountPaid)
        {
            consumedFoods.RemoveAt(uneatenFoodIndex);
            var paymentThatAnnaMustPay = consumedFoods.Aggregate((x, y) => x + y) / 2;
            var refundAmount = amountPaid - paymentThatAnnaMustPay;
            return refundAmount > 0 ? refundAmount.ToString() : "Bon Appetit";
        }

        public static bool Validate(List<int> consumedFoods, int uneatenFoodIndex, int amountPaid)
        {
            if (consumedFoods.Count < 2 || consumedFoods.Count > Math.Pow(10, 5)) return false;
            if (uneatenFoodIndex < 0 || uneatenFoodIndex > consumedFoods.Count) return false;
            foreach (var number in consumedFoods)
            {
                if (number < 0 || number > Math.Pow(10, 4)) return false;
            }
            if(amountPaid < 0 || amountPaid > consumedFoods.Aggregate((x, y) => x + y)) return false;
            return true;
        }
    }
}
