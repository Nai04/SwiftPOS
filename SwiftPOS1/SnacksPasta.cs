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
    public partial class SnacksPasta : Form
    {
        public SnacksPasta()
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

        private void btnPastry_Click(object sender, EventArgs e)
        {
            Pastry pastry = new Pastry();
            pastry.Show();
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

        private void btnAddToCartFries_Click(object sender, EventArgs e)
        {
            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyFries.Text.Trim();

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

            MessageBox.Show("Flavored Fries " + " x " + qty + " added to cart!");
            txtQtyFries.Clear();
        }

        private void btnAddToCartNachos_Click(object sender, EventArgs e)
        {
            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyNachos.Text.Trim();

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

            MessageBox.Show("Nachos " + " x " + qty + " added to cart!");
            txtQtyNachos.Clear();
        }

        private void btnAddToCartSiomai_Click(object sender, EventArgs e)
        {
            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtySiomai.Text.Trim();

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

            MessageBox.Show("Siomai " + " x " + qty + " added to cart!");
            txtQtySiomai.Clear();
        }

        private void btnAddToCartCarb_Click(object sender, EventArgs e)
        {
            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyCarb.Text.Trim();

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

            MessageBox.Show("Carbonara " + " x " + qty + " added to cart!");
            txtQtyCarb.Clear();
        }

        private void btnAddToCartPesto_Click(object sender, EventArgs e)
        {
            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyPesto.Text.Trim();

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

            MessageBox.Show("Pesto Pasta " + " x " + qty + " added to cart!");
            txtQtyPesto.Clear();
        }

        private void btnAddToCartGambas_Click(object sender, EventArgs e)
        {
            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyGambas.Text.Trim();

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

            MessageBox.Show("Gambas Pasta " + " x " + qty + " added to cart!");
            txtQtyGambas.Clear();
        }
    }
}
