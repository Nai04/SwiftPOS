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

            MessageBox.Show("Wintermelon (" + size + ") added to cart!");
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

            MessageBox.Show("Okinawa (" + size + ") added to cart!");
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

            MessageBox.Show("Cookies and Cream (" + size + ") added to cart!");
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

            MessageBox.Show("Salted Caramel (" + size + ") added to cart!");
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

            MessageBox.Show("Hokaido (" + size + ") added to cart!");
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

            MessageBox.Show("Thai (" + size + ") added to cart!");
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

            MessageBox.Show("Matcha (" + size + ") added to cart!");
        }
    }
}
