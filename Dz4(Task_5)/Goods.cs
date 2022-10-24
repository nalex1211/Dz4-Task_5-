using System;
using System.Windows.Forms;

namespace Dz4_Task_5_
{
    public class Goods
    {
        public int Price { get;  }
        public string Name { get; }
        public string Description { get; }
        public string Country { get; }
        public DateTime DateOfDelivery { get; }

        public Goods(string price, string name, string description, string country, DateTime dateOfDelivery)
        {
            if (!int.TryParse(price, out _))
            {
                MessageBox.Show("Please enter number in \"Price\" section");
                return;
            }
            Price = Convert.ToInt32(price);
            Name = name ?? throw new ArgumentNullException(nameof(Name));
            Description = description ?? throw new ArgumentNullException(nameof(Country));
            Country = country ?? throw new ArgumentNullException(nameof(Country));
            DateOfDelivery = dateOfDelivery;
        }
    }
}
