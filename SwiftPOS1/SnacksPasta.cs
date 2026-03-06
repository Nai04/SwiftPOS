using SiticoneNetFrameworkUI;
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

        //quantity class/logic

        private bool TryGetQty(SiticoneTextBoxAdvanced qtyBox, out int qty)
        {
            qty = 0;

            string qtyText = qtyBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(qtyText))
            {
                MessageBox.Show("Enter quantity first.", "Missing Quantity",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(qtyText, out qty))
            {
                MessageBox.Show("Quantity must be a valid number.", "Invalid Quantity",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (qty <= 0)
            {
                MessageBox.Show("Quantity must be higher than 0.", "Invalid Quantity",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        //add to cart method
        private void AddSnackToCart(
            string itemName,
            SiticoneTextBoxAdvanced qtyBox,
            decimal price)
        {
            if (!TryGetQty(qtyBox, out int qty)) return;

            CartService.AddItem(itemName, "", price, qty);

            MessageBox.Show($"{itemName} x{qty} added to cart!",
                "Added to Cart",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            qtyBox.Clear();
        }

        private void GoTo(Form next)
        {
            next.Show();
            this.Hide();
        }

        //navigation buttons

        private void btnCoffee_Click(object sender, EventArgs e) => GoTo(new Coffee());

        private void btnMilktea_Click(object sender, EventArgs e) => GoTo(new MilkTea());

        private void btnFruitTea_Click(object sender, EventArgs e) => GoTo(new FruitTea());

        private void btnRiceMeal_Click(object sender, EventArgs e) => GoTo(new Rice_Meal());

        private void btnPastry_Click(object sender, EventArgs e) => GoTo(new Pastry());

        private void btnMenu_Click(object sender, EventArgs e) => GoTo(new Menu());

        private void btnCart_Click(object sender, EventArgs e) => GoTo(new Cart());

        //add to cart buttons

        private void btnAddToCartFries_Click(object sender, EventArgs e)
        {
            AddSnackToCart("Flavored Fries", txtQtyFries, 75m);
        }

        private void btnAddToCartNachos_Click(object sender, EventArgs e)
        {
            AddSnackToCart("Nachos", txtQtyNachos, 85m);
        }

        private void btnAddToCartSiomai_Click(object sender, EventArgs e)
        {
            AddSnackToCart("Siomai", txtQtySiomai, 65m);
        }

        private void btnAddToCartCarb_Click(object sender, EventArgs e)
        {
            AddSnackToCart("Carbonara", txtQtyCarb, 120m);
        }

        private void btnAddToCartPesto_Click(object sender, EventArgs e)
        {
            AddSnackToCart("Pesto Pasta", txtQtyPesto, 120m);
        }

        private void btnAddToCartGambas_Click(object sender, EventArgs e)
        {
            AddSnackToCart("Gambas Pasta", txtQtyGambas, 130m);
        }
    }
}
