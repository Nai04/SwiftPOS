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
    public partial class FruitTea : Form
    {
        public FruitTea()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
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

        private void btnCart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
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

        private void txtQtyCapp_TextContentChanged(object sender, EventArgs e)
        {

        }

        private void btnAddToCartAmer_Click(object sender, EventArgs e)
        {
            // Size checker and add to cart logic
            string size = "";

            if (rbtnSmallGApple.Checked)
            {
                size = "Small";
            }
            else if (rbtnLargeGApple.Checked)
            {
                size = "Large";
            }
            else
            {
                MessageBox.Show("Select size first!", "No Size Choosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyGApple.Text.Trim();

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

            MessageBox.Show("Green Apple (" + size + ") x" + qty + " added to cart!");
            txtQtyGApple.Clear();
        }

        private void btnAddToCartStrawberry_Click(object sender, EventArgs e)
        {
            // Size checker and add to cart logic
            string size = "";

            if (rbtnSmallStrawberry.Checked)
            {
                size = "Small";
            }
            else if (rbtnLargeStrawberry.Checked)
            {
                size = "Large";
            }
            else
            {
                MessageBox.Show("Select size first!", "No Size Choosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyStrawberry.Text.Trim();

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

            MessageBox.Show("Strawberry (" + size + ") x" + qty + " added to cart!");
            txtQtyStrawberry.Clear();
        }

        private void btnAddToCartBlueberry_Click(object sender, EventArgs e)
        {
            // Size checker and add to cart logic
            string size = "";

            if (rbtnSmallBlueberry.Checked)
            {
                size = "Small";
            }
            else if (rbtnLargeBlueberry.Checked)
            {
                size = "Large";
            }
            else
            {
                MessageBox.Show("Select size first!", "No Size Choosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyBlueberry.Text.Trim();

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

            MessageBox.Show("Blueberry (" + size + ") x" + qty + " added to cart!");
            txtQtyBlueberry.Clear();
        }

        private void btnAddToCartMango_Click(object sender, EventArgs e)
        {
            // Size checker and add to cart logic
            string size = "";

            if (rbtnSmallMango.Checked)
            {
                size = "Small";
            }
            else if (rbtnLargeMango.Checked)
            {
                size = "Large";
            }
            else
            {
                MessageBox.Show("Select size first!", "No Size Choosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyMango.Text.Trim();

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

            MessageBox.Show("Mango (" + size + ") x" + qty + " added to cart!");
            txtQtyMango.Clear();
        }

        private void btnAddToCartPeach_Click(object sender, EventArgs e)
        {
            // Size checker and add to cart logic
            string size = "";

            if (rbtnSmallPeach.Checked)
            {
                size = "Small";
            }
            else if (rbtnLargePeach.Checked)
            {
                size = "Large";
            }
            else
            {
                MessageBox.Show("Select size first!", "No Size Choosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyPeach.Text.Trim();

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

            MessageBox.Show("Peach (" + size + ") x" + qty + " added to cart!");
            txtQtyPeach.Clear();
        }

        private void btnAddToCartLychee_Click(object sender, EventArgs e)
        {
            // Size checker and add to cart logic
            string size = "";

            if (rbtnSmallLychee.Checked)
            {
                size = "Small";
            }
            else if (rbtnLargeLychee.Checked)
            {
                size = "Large";
            }
            else
            {
                MessageBox.Show("Select size first!", "No Size Choosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyLychee.Text.Trim();

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

            MessageBox.Show("Lychee (" + size + ") x" + qty + " added to cart!");
            txtQtyLychee.Clear();
        }
    }
}
