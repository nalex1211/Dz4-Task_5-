using System;
using System.Windows.Forms;

namespace Dz4_Task_5_
{
    public class Books : Goods
    {
        public int AmountOfPages { get; set; }
        public string PublishingHouse { get; set; }
        public string Author { get; set; }

        public Books(string amountOfPages, string publishingHouse, string author,
            string price, string name, string description, string country, DateTime dateOfDelivery)
            : base(price, name, description, country, dateOfDelivery)
        {
            if (!int.TryParse(amountOfPages.ToString(), out _))
            {
                MessageBox.Show("Please enter number in \"Amount of pages\" section");
                return;
            }
            AmountOfPages = Convert.ToInt32(amountOfPages);
            PublishingHouse = publishingHouse ?? throw new ArgumentNullException(nameof(PublishingHouse));
            Author = author ?? throw new ArgumentNullException(nameof(Author));
        }
    }
}
