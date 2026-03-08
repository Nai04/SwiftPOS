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
    public partial class Pastry : Form
    {
        public Pastry()
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
        // Add to cart logic for pastries
        private void AddPastryToCart(
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

        private void btnMenu_Click(object sender, EventArgs e) => GoTo(new Menu());

        private void btnCart_Click(object sender, EventArgs e) => GoTo(new Cart());

        private void btnSnacksPasta_Click(object sender, EventArgs e) => GoTo(new SnacksPasta());

        //add to cart buttons for pastries

        private void btnAddToCartChocoCook_Click(object sender, EventArgs e)
        {
            AddPastryToCart("Chocolate Cookies", txtQtyChocoCook, 69m);
        }

        private void btnAddToCartCroissant_Click(object sender, EventArgs e)
        {
            AddPastryToCart("Croissant", txtQtyCroissant, 79m);
        }

        private void btnAddToCartCheeseEns_Click(object sender, EventArgs e)
        {
            AddPastryToCart("Cheese Ensaymada", txtQtyCheeseEns, 65m);
        }

        private void btnAddToCartYemaEns_Click(object sender, EventArgs e)
        {
            AddPastryToCart("Yema Ensaymada", txtQtyYemaEns, 65m);
        }

        private void btnAddToCartUbeEns_Click(object sender, EventArgs e)
        {
            AddPastryToCart("Ube Ensaymada", txtQtyUbeEns, 65m);
        }

        private void btnAddToCartChocoDonut_Click(object sender, EventArgs e)
        {
            AddPastryToCart("Chocolate Donut", txtQtyChocoDonut, 55m);
        }

        private void btnAddToCartCinnamon_Click(object sender, EventArgs e)
        {
            AddPastryToCart("Cinnamon Roll", txtQtyCinnamon, 75m);
        }
    }
}
