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
    public partial class Rice_Meal : Form
    {
        public Rice_Meal()
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

        private void AddRiceMealToCart(
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

        private void btnMenu_Click(object sender, EventArgs e) => GoTo(new Menu());

        private void btnCart_Click(object sender, EventArgs e) => GoTo(new Cart());

        private void btnPastry_Click(object sender, EventArgs e) => GoTo(new Pastry());

        //add to cart buttons for rice meals

        private void btnAddToCartAmer_Click(object sender, EventArgs e)
        {
            AddRiceMealToCart("Silog", txtQtySilog, 120m);
        }

        private void btnAddToCartHSilog_Click(object sender, EventArgs e)
        {
            AddRiceMealToCart("Hotdog Silog", txtQtyHSilog, 120m);
        }

        private void btnAddToCartLongSilog_Click(object sender, EventArgs e)
        {
            AddRiceMealToCart("Longganisa Silog", txtQtyLongSilog, 120m);
        }

        private void btnAddToCartHamSilog_Click(object sender, EventArgs e)
        {
            AddRiceMealToCart("Ham Silog", txtQtyHamSilog, 120m);
        }

        private void btnAddToCartEmbSilog_Click(object sender, EventArgs e)
        {
            AddRiceMealToCart("Embotido Silog", txtQtyEmbSilog, 120m);
        }

        private void btnAddToCartShangSilog_Click(object sender, EventArgs e)
        {
            AddRiceMealToCart("Shanghai Silog", txtQtyShangSilog, 120m);
        }

        private void Rice_Meal_Load(object sender, EventArgs e)
        {

        }
    }
}
