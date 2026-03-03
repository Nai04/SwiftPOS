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
    public partial class Pastry : Form
    {
        public Pastry()
        {
            InitializeComponent();
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

        private void btnRiceMeal_Click(object sender, EventArgs e)
        {
            Rice_Meal rice_Meal = new Rice_Meal();
            rice_Meal.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
           Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Hide();
        }

        private void btnSnacksPasta_Click(object sender, EventArgs e)
        {
            SnacksPasta snacksPasta = new SnacksPasta();
            snacksPasta.Show();
            this.Hide();
        }

        private void btnAddToCartChocoCook_Click(object sender, EventArgs e)
        {
            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyChocoCook.Text.Trim();

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

            MessageBox.Show("Chocolate Cookies " + " x " + qty + " added to cart!");
            txtQtyChocoCook.Clear();
        }

        private void btnAddToCartCroissant_Click(object sender, EventArgs e)
        {
            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyCroissant.Text.Trim();

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

            MessageBox.Show("Croissant " + " x " + qty + " added to cart!");
            txtQtyCroissant.Clear();
        }

        private void btnAddToCartCheeseEns_Click(object sender, EventArgs e)
        {
            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyCheeseEns.Text.Trim();

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

            MessageBox.Show("Cheese Ensaymada " + " x " + qty + " added to cart!");
            txtQtyCheeseEns.Clear();
        }

        private void btnAddToCartYemaEns_Click(object sender, EventArgs e)
        {
            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyYemaEns.Text.Trim();

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

            MessageBox.Show("Yema Ensaymada " + " x " + qty + " added to cart!");
            txtQtyYemaEns.Clear();
        }

        private void btnAddToCartUbeEns_Click(object sender, EventArgs e)
        {
            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyUbeEns.Text.Trim();

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

            MessageBox.Show("Ube Ensaymada " + " x " + qty + " added to cart!");
            txtQtyUbeEns.Clear();
        }

        private void btnAddToCartChocoDonut_Click(object sender, EventArgs e)
        {
            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyChocoDonut.Text.Trim();

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

            MessageBox.Show("Chocolate Donut " + " x " + qty + " added to cart!");
            txtQtyChocoDonut.Clear();
        }

        private void btnAddToCartCinnamon_Click(object sender, EventArgs e)
        {
            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyCinnamon.Text.Trim();

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

            MessageBox.Show("Cinnamon " + " x " + qty + " added to cart!");
            txtQtyCinnamon.Clear();
        }
    }
}
