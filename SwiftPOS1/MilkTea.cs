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
    public partial class MilkTea : Form
    {
        public MilkTea()
        {
            InitializeComponent();
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            Coffee coffee = new Coffee();
            coffee.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnAddToCartAmer_Click(object sender, EventArgs e)
        {
            // Size checker and add to cart logic
            string size = "";

            if (rbtnSmallWinter.Checked)
            {
                size = "Small";
            }
            else if (rbtnLargeWinter.Checked)
            {
                size = "Large";
            }
            else
            {
                MessageBox.Show("Select size first!", "No Size Choosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyWinter.Text.Trim();

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

            MessageBox.Show("Wintermelon (" + size + ") x" + qty + " added to cart!");
            txtQtyWinter.Clear();
        }

        private void btnAddtoCartOki_Click(object sender, EventArgs e)
        {
            // Size checker and add to cart logic
            string size = "";

            if (rbtnSmallOki.Checked)
            {
                size = "Small";
            }
            else if (rbtnLargeOki.Checked)
            {
                size = "Large";
            }
            else
            {
                MessageBox.Show("Select size first!", "No Size Choosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyOkinawa.Text.Trim();

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

            MessageBox.Show("Okinawa (" + size + ") x" + qty + " added to cart!");
            txtQtyOkinawa.Clear();
        }

        private void btnAddtoCartCandC_Click(object sender, EventArgs e)
        {
            // Size checker and add to cart logic
            string size = "";

            if (rbtnSmallCandC.Checked)
            {
                size = "Small";
            }
            else if (rbtnLargeCandC.Checked)
            {
                size = "Large";
            }
            else
            {
                MessageBox.Show("Select size first!", "No Size Choosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyCandC.Text.Trim();

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

            MessageBox.Show("Cookies and Cream (" + size + ") x" + qty + " added to cart!");
            txtQtyCandC.Clear();
        }

        private void btnAddtoCartSaltCarm_Click(object sender, EventArgs e)
        {
            // Size checker and add to cart logic
            string size = "";

            if (rbtnSmallSaltCarm.Checked)
            {
                size = "Small";
            }
            else if (rbtnLargeSaltCarm.Checked)
            {
                size = "Large";
            }
            else
            {
                MessageBox.Show("Select size first!", "No Size Choosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtySaltCarm.Text.Trim();

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

            MessageBox.Show("Salted Caramel (" + size + ") x" + qty + " added to cart!");
            txtQtySaltCarm.Clear();
        }

        private void btnAddtoCartHokaido_Click(object sender, EventArgs e)
        {
            // Size checker and add to cart logic
            string size = "";

            if (rbtnSmallHokaido.Checked)
            {
                size = "Small";
            }
            else if (rbtnLargeHokaido.Checked)
            {
                size = "Large";
            }
            else
            {
                MessageBox.Show("Select size first!", "No Size Choosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyHokk.Text.Trim();

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

            MessageBox.Show("Hokkaido (" + size + ") x" + qty + " added to cart!");
            txtQtyHokk.Clear();
        }

        private void btnAddtoCartThai_Click(object sender, EventArgs e)
        {
            // Size checker and add to cart logic
            string size = "";

            if (rbtnSmallThai.Checked)
            {
                size = "Small";
            }
            else if (rbtnLargeThai.Checked)
            {
                size = "Large";
            }
            else
            {
                MessageBox.Show("Select size first!", "No Size Choosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyThai.Text.Trim();

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

            MessageBox.Show("Thai (" + size + ") x" + qty + " added to cart!");
            txtQtyThai.Clear();
        }

        private void btnAddtoCartMatcha_Click(object sender, EventArgs e)
        {
            // Size checker and add to cart logic
            string size = "";

            if (rbtnSmallMatcha.Checked)
            {
                size = "Small";
            }
            else if (rbtnLargeMatcha.Checked)
            {
                size = "Large";
            }
            else
            {
                MessageBox.Show("Select size first!", "No Size Choosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ---- ADD THIS (quantity) ----
            string qtyText = txtQtyMatcha.Text.Trim();

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

            MessageBox.Show("Matcha (" + size + ") x" + qty + " added to cart!");
            txtQtyMatcha.Clear();
        }

        private void btnFruitTea_Click(object sender, EventArgs e)
        {
            FruitTea fruitTea = new FruitTea();
            fruitTea.Show();
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
    }
}
