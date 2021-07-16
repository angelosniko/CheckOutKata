using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataCheckout.Interface
{
    public class Checkout:ICheckout
    {

        private readonly IList<Discount> _discounts;
     
        private readonly IDictionary<string, int> _priceList;
        private readonly IList<string> _itemsList;

        public Checkout(IDictionary<string, int> priceList,IList<Discount> discounts=null) {

            _itemsList = new List<string>();
           _discounts = discounts ?? new List<Discount>();
            _priceList = priceList;
        
        
        }


        public void Scan(string item) {
            _itemsList.Add(item);
        
        }

        public int GetTotalPrice() {

            var total = _itemsList.Sum(item => _priceList[item]);

            foreach (var DiscountItem in _discounts)
            {

                //var valueA = priceList.Where(x => x.Key == itemDiscount.Sku).Select(x => x.Value);
                var val = _priceList[DiscountItem.Sku];

                var CountItem = _itemsList.Count(i => i == DiscountItem.Sku);
                total = total - (CountItem / DiscountItem.CountValue) * ((CountItem* val) - DiscountItem.Price);                                   

            }

            return total;
        
        }




    }
}
