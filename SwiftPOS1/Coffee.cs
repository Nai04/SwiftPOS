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
    public partial class Coffee : Form
    {
        public Coffee()
        {
            InitializeComponent();
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            // Size checker and add to cart logic
            string size = "";

            if (rbtnSmallAmer.Checked)
            {
                size = "Small";
            }
            else if (rbtnLargeAmer.Checked)
            {
                size = "Large";
            }
            else
            {
                MessageBox.Show("Select size first!", "No Size Choosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ---- ADD THIS (quantity) ----
            string qtyText = txtQuantityAmer.Text.Trim();

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

            MessageBox.Show("Iced Mocha Latte (" + size + ") x" + qty + " added to cart!");
            txtQuantityAmer.Clear();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  
            form1.Show();
            this.Hide();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Hide();
        }

        private void btnMilktea_Click(object sender, EventArgs e)
        {
            MilkTea milkTea = new MilkTea();
            milkTea.Show();
            this.Hide();
        }

        private void btnAddtoCartCapp_Click(object sender, EventArgs e)
        {
            // Size checker and add to cart logic
            string size = "";

            if (rbtnSmallCapp.Checked)
            {
                size = "Small";
            }
            else if (rbtnLargeCapp.Checked)
            {
                size = "Large";
            }
            else
            {
                MessageBox.Show("Select size first!", "No Size Choosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyCapp.Text.Trim();

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

            MessageBox.Show("Cappuccino (" + size + ") x" + qty + " added to cart!");
            txtQtyCapp.Clear();
        }

        private void btnAddToCartHChoc_Click(object sender, EventArgs e)
        {
            // Size checker and add to cart logic
            string size = "";

            if (rbtnSmallHChoc.Checked)
            {
                size = "Small";
            }
            else if (rbtnLargeHChoc.Checked)
            {
                size = "Large";
            }
            else
            {
                MessageBox.Show("Select size first!", "No Size Choosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ---- ADD THIS (quantity) ----
            string qtyText = txtQuantityHChoc.Text.Trim();

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

            MessageBox.Show("Hot Choco (" + size + ") x" + qty + " added to cart!");
            txtQuantityHChoc.Clear();
        }

        private void btnAddToCartHLatte_Click(object sender, EventArgs e)
        {
            // Size checker and add to cart logic
            string size = "";

            if (rbtnSmallHotLatte.Checked)
            {
                size = "Small";
            }
            else if (rbtnLargeHotLatte.Checked)
            {
                size = "Large";
            }
            else
            {
                MessageBox.Show("Select size first!", "No Size Choosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyHLatte.Text.Trim();

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

            MessageBox.Show("Hot Latte (" + size + ") x" + qty + " added to cart!");
            txtQtyHLatte.Clear();
        }

        private void btnAddToCartSpaLattte_Click(object sender, EventArgs e)
        {
            // Size checker and add to cart logic
            string size = "";

            if (rbtnSmallSpaLatte.Checked)
            {
                size = "Small";
            }
            else if (rbtnLargeSpaLatte.Checked)
            {
                size = "Large";
            }
            else
            {
                MessageBox.Show("Select size first!", "No Size Choosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtySpaLatte.Text.Trim();

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

            MessageBox.Show("Spanish Latte (" + size + ") x" + qty + " added to cart!");
            txtQtySpaLatte.Clear();
        }

        private void btnAddToCartHMocLatte_Click(object sender, EventArgs e)
        {
            // Size checker and add to cart logic
            string size = "";

            if (rbtnSmallHMochLatte.Checked)
            {
                size = "Small";
            }
            else if (rbntLargeHMochaLatte.Checked)
            {
                size = "Large";
            }
            else
            {
                MessageBox.Show("Select size first!", "No Size Choosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyHMochaLatte.Text.Trim();

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

            MessageBox.Show("Hot Mocha Latte (" + size + ") x" + qty + " added to cart!");
            txtQtyHMochaLatte.Clear();
        }

        private void btnAddToCartIceLatte_Click(object sender, EventArgs e)
        {
            // Size checker and add to cart logic
            string size = "";

            if (rbtnSmallIcedLatte.Checked)
            {
                size = "Small";
            }
            else if (rbtnLargeIcedLatte.Checked)
            {
                size = "Large";
            }
            else
            {
                MessageBox.Show("Select size first!", "No Size Choosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyIcedLatte.Text.Trim();

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

            MessageBox.Show("Iced Latte (" + size + ") x" + qty + " added to cart!");
            txtQtyIcedLatte.Clear();
        }

        private void btnAddToCartIcedMochLatte_Click(object sender, EventArgs e)
        {
            // Size checker and add to cart logic
            string size = "";

            if (rbtnSmallIcedMochaLatte.Checked)
            {
                size = "Small";
            }
            else if (rbtnLargeIcedMochaLatte.Checked)
            {
                size = "Large";
            }
            else
            {
                MessageBox.Show("Select size first!", "No Size Choosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyIcedMochaLatte.Text.Trim();

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

            MessageBox.Show("Iced Mocha Latte (" + size + ") x" + qty + " added to cart!");
            txtQtyIcedMochaLatte.Clear();
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

        private void siticoneTextBoxAdvanced1_TextContentChanged(object sender, EventArgs e)
        {

        }

        private void Coffee_Load(object sender, EventArgs e)
        {

        }
    }
}
