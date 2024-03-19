using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoLibrary
{
    public class clsShoppingCartModel
    {
        public delegate void MentionDiscount(decimal subTotal);

        public List<clsProductModel> Items { get; set; } = new List<clsProductModel>();

        public decimal GenerateTotal(MentionDiscount mentionDiscount,
            Func<List<clsProductModel>, decimal, decimal> calculateDiscountTotal,
            Action<string> tellUserWeAreDiscounting)
        {
            decimal subTotal = Items.Sum(item => item.Price);

            mentionDiscount?.Invoke(subTotal);

            tellUserWeAreDiscounting?.Invoke("We are applying your discount...");

            return calculateDiscountTotal?.Invoke(Items, subTotal) ?? 0;
        }

    }
}
