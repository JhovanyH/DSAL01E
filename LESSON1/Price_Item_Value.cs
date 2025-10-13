using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON1
{
    internal class Price_Item_Value
    {
        public string price, itemname, discount_amount;

        public void SetPriceItemValue(string item_name, string item_price)
        {
            this.itemname = item_name;
            this.price = item_price;
        }
        public string GetItemName()
        {
            return itemname;
        }

        public string GetPrice()
        {
            return price;
        }
        public void SetPriceDiscountAmountValue(string discount_amt, string priceitem)
        {
            this.price = priceitem;
            this.discount_amount = discount_amt;
        }
        
        public string GetPriceItem()
        {
            return price;
        }

        public string GetDiscountAmount()
        {
            return discount_amount;
        }


    }
}
