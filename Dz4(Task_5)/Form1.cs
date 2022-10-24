using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dz4_Task_5_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Books> lstOfBooks = new List<Books>();
            Form2 form = new Form2();
            form.ShowDialog();

            var book = new Books(
                form.txtAmount.Text,
                form.txtHouse.Text,
                form.txtAuthor.Text,
                form.txtPrice.Text,
                form.txtName.Text,
                form.txtDescription.Text,
                form.txtCountry.Text,
                DateTime.Now);

            lstOfBooks.Add(book);
            foreach (var b in lstOfBooks)
            {
                listOfGoods.Rows.Add(b.Name, b.Price, b.Description, b.DateOfDelivery, b.Country, b.AmountOfPages,
                    b.Author, b.PublishingHouse);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Products> lstOfProducts = new List<Products>();
            Form3 form = new Form3();
            form.ShowDialog();

            var product = new Products(
                form.txtExpiration.Text,
                form.txtAmount.Text,
                form.txtUnit.Text,
                form.txtPrice.Text,
                form.txtName.Text,
                form.txtDescription.Text,
                form.txtCountry.Text,
                DateTime.Now);

            lstOfProducts.Add(product);
            foreach (var p in lstOfProducts)
            {
                listOfProducts.Rows.Add(p.Name, p.Price, p.Description, p.DateOfDelivery, p.Country,
                    p.ExpirationDate, p.Unit, p.Amount);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in listOfGoods.SelectedRows)
            {
                listOfGoods.Rows.Remove(row);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in listOfProducts.SelectedRows)
            {
                listOfProducts.Rows.Remove(row);
            }
        }
    }
}
