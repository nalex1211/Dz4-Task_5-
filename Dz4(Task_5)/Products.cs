using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4_Task_5_
{
    public class Products : Goods
    {
        private string ExpirationDate;
        private int Amount;
        private string Unit;

        public Products(string expirationDate, int amount, string unit,
            int price, string name, string description, string country, string dateOfDelivery)
            : base(price, name, description, country, dateOfDelivery)
        {
            ExpirationDate = expirationDate;
            Amount = amount;
            Unit = unit;
        }
    }
}
