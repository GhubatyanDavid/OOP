using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PricesinShop
{
    struct Price
    {
        private string _productName;
        private string _shopName;
        private int _price;
        public Price(string productName,string shopName,int price)
        {
            _productName = productName;
            _shopName = shopName;
            _price = price;
        }
        public override string ToString()
        {
            return $"Shop Name ` {_shopName} ,Product Name ` {_productName} , Price ` {_price} AMD ";
        }
    }
}
