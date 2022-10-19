using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4_Task_5_
{
    public class Goods
    {
        private int Price;
        public int price { get => Price; }
        private string Name;
        public string name { get => Name; }
        private string Description;
        public string description { get => Description; }
        private string Country;
        public string country { get => Country; }
        private string DateOfDelivery;
        public string dateOfDelivery { get => DateOfDelivery; }

        public Goods(int price, string name, string description, string country, string dateOfDelivery)
        {
            Price = price;
            Name = name;
            Description = description;
            Country = country;
            DateOfDelivery = dateOfDelivery;
        }
    }
}
