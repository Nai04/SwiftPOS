using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftPOS1
{
    public partial class Rice_Meal : Form
    {
        public Rice_Meal()
        {
            InitializeComponent();
        }

        private void Rice_Meal_Load(object sender, EventArgs e)
        {

        }

        private void rbtnLargeAmer_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToCartAmer_Click(object sender, EventArgs e)
        {


            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtySilog.Text.Trim();

            if (string.IsNullOrWhiteSpace(qtyText))
            {
                MessageBox.Show("Enter quantity first!", "No Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(qtyText, out int qty) || qty < 1)
            {
                MessageBox.Show("Quantity must be a number 1 or higher!", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // ---- END ADD ----

            MessageBox.Show("Silog " + " x " + qty + " added to cart!");
            txtQtySilog.Clear();
        }

        private void rbtnSmallAmer_Click(object sender, EventArgs e)
        {

        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            Coffee coffee = new Coffee();
            coffee.Show();
            this.Hide();
        }

        private void btnMilktea_Click(object sender, EventArgs e)
        {
            MilkTea milkTea = new MilkTea();
            milkTea.Show();
            this.Hide();
        }

        private void btnFruitTea_Click(object sender, EventArgs e)
        {
            FruitTea fruitTea = new FruitTea();
            fruitTea.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Hide();
        }

        private void btnPastry_Click(object sender, EventArgs e)
        {
            Pastry pastry = new Pastry();
            pastry.Show();
            this.Hide();
        }

        private void btnAddToCartHSilog_Click(object sender, EventArgs e)
        {
            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyHSilog.Text.Trim();

            if (string.IsNullOrWhiteSpace(qtyText))
            {
                MessageBox.Show("Enter quantity first!", "No Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(qtyText, out int qty) || qty < 1)
            {
                MessageBox.Show("Quantity must be a number 1 or higher!", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // ---- END ADD ----

            MessageBox.Show("Hot Silog " + " x " + qty + " added to cart!");
            txtQtyHSilog.Clear();
        }

        private void btnAddToCartLongSilog_Click(object sender, EventArgs e)
        {
            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyLongSilog.Text.Trim();

            if (string.IsNullOrWhiteSpace(qtyText))
            {
                MessageBox.Show("Enter quantity first!", "No Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(qtyText, out int qty) || qty < 1)
            {
                MessageBox.Show("Quantity must be a number 1 or higher!", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // ---- END ADD ----

            MessageBox.Show("Long Silog " + " x " + qty + " added to cart!");
            txtQtyLongSilog.Clear();
        }

        private void btnAddToCartHamSilog_Click(object sender, EventArgs e)
        {
            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyHamSilog.Text.Trim();

            if (string.IsNullOrWhiteSpace(qtyText))
            {
                MessageBox.Show("Enter quantity first!", "No Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(qtyText, out int qty) || qty < 1)
            {
                MessageBox.Show("Quantity must be a number 1 or higher!", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // ---- END ADD ----

            MessageBox.Show("Ham Silog " + " x " + qty + " added to cart!");
            txtQtyHamSilog.Clear();
        }

        private void btnAddToCartEmbSilog_Click(object sender, EventArgs e)
        {
            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyEmbSilog.Text.Trim();

            if (string.IsNullOrWhiteSpace(qtyText))
            {
                MessageBox.Show("Enter quantity first!", "No Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(qtyText, out int qty) || qty < 1)
            {
                MessageBox.Show("Quantity must be a number 1 or higher!", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // ---- END ADD ----

            MessageBox.Show("Embotido Silog " + " x " + qty + " added to cart!");
            txtQtyEmbSilog.Clear();
        }

        private void btnAddToCartShangSilog_Click(object sender, EventArgs e)
        {
            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyShangSilog.Text.Trim();

            if (string.IsNullOrWhiteSpace(qtyText))
            {
                MessageBox.Show("Enter quantity first!", "No Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(qtyText, out int qty) || qty < 1)
            {
                MessageBox.Show("Quantity must be a number 1 or higher!", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // ---- END ADD ----

            MessageBox.Show("Shanghai Silog " + " x " + qty + " added to cart!");
            txtQtyShangSilog.Clear();
        }
    }
}
