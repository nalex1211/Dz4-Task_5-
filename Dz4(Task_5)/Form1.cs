using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz4_Task_5_
{
    public partial class Form1 : Form
    {
        List<Goods> map = new List<Goods>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            var book = new Books(Convert.ToInt32(form.txtAmount.Text),
                form.txtHouse.Text, form.txtAuthor.Text, Convert.ToInt32(form.txtPrice.Text),
                form.txtName.Text, form.txtDescription.Text, form.txtCountry.Text, form.txtDateOfDelivery.Text);

            map.Add(book);
            map.ForEach(w => listOfGoods.Rows.Add(w.name, w.price, w.description, w.dateOfDelivery, w.country));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
            var grocery = new Books(Convert.ToInt32(form.txtAmount.Text),
               form.txtHouse.Text, form.txtAuthor.Text, Convert.ToInt32(form.txtPrice.Text),
               form.txtName.Text, form.txtDescription.Text, form.txtCountry.Text, form.txtDateOfDelivery.Text);

            map.Add(grocery);
            map.ForEach(w => listOfGoods.Rows.Add(w.name, w.price, w.description, w.dateOfDelivery, w.country));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           foreach (DataGridViewRow row in listOfGoods.SelectedRows) {
                listOfGoods.Rows.Remove(row);
            }
        }
    }
}
