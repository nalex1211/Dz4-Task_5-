using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4_Task_5_
{
    public class Books : Goods
    {
        private int AmountOfPages;
        private string PublishingHouse;
        private string Author;

        public Books(int amountOfPages, string publishingHouse, string author,
            int price, string name, string description, string country, string dateOfDelivery)
            : base(price, name, description, country, dateOfDelivery)
        {
            AmountOfPages = amountOfPages;
            PublishingHouse = publishingHouse;
            Author = author;
        }
    }
}
