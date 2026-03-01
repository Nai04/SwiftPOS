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
                MessageBox.Show("Select size first!","No Size Choosen",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Americano (" + size + ") added to cart!");
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

            MessageBox.Show("Cappuccino (" + size + ") added to cart!");
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

            MessageBox.Show("Hot Choco (" + size + ") added to cart!");
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

            MessageBox.Show("Hot Latte (" + size + ") added to cart!");
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

            MessageBox.Show("Spanish Latte (" + size + ") added to cart!");
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

            MessageBox.Show("Hot Mocha Latte (" + size + ") added to cart!");
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

            MessageBox.Show("Iced Latte (" + size + ") added to cart!");
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

            MessageBox.Show("Iced Mocha Latte (" + size + ") added to cart!");
        }
    }
}
