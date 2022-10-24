using System;
using System.Windows.Forms;

namespace Dz4_Task_5_
{
    public class Products : Goods
    {
        public string ExpirationDate { get; set; }
        public int Amount { get; set; }
        public string Unit { get; set; }

        public Products(string expirationDate,
            string amount,
            string unit,
            string price,
            string name,
            string description,
            string country,
            DateTime dateOfDelivery)
            : base(price, name, description, country, dateOfDelivery)
        {
            if (!int.TryParse(amount, out _))
            {
                MessageBox.Show("Please enter number in \"Amount\" section");
                return;
            }
            ExpirationDate = expirationDate ?? throw new ArgumentNullException(nameof(ExpirationDate));
            Amount = Convert.ToInt32(amount);
            Unit = unit ?? throw new ArgumentNullException(nameof(Unit));
        }
    }
}
