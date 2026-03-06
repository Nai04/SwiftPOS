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
    public partial class MilkTea : Form
    {
        public MilkTea()
        {
            InitializeComponent();
        }

        // size classs

        private bool TryGetSize(SiticoneRadioButton smallBtn, SiticoneRadioButton largeBtn, out string size)
        {
            size = "";

            if (smallBtn.Checked)
            {
                size = "Small";
                return true;
            }

            if (largeBtn.Checked)
            {
                size = "Large";
                return true;
            }

            MessageBox.Show("Please select a size first.", "Missing Size",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        // quantity class/logic
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
        // Add to cart logic/cass
        private void AddDrinkToCart(
            string itemName,
            SiticoneRadioButton smallBtn,
            SiticoneRadioButton largeBtn,
            SiticoneTextBoxAdvanced qtyBox,
            decimal smallPrice,
            decimal largePrice)
        {
            if (!TryGetSize(smallBtn, largeBtn, out string size)) return;
            if (!TryGetQty(qtyBox, out int qty)) return;

            decimal price = (size == "Small") ? smallPrice : largePrice;

            CartService.AddItem(itemName, size, price, qty);

            MessageBox.Show($"{itemName} ({size}) x{qty} added to cart!", "Added to Cart",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            qtyBox.Clear();
        }

        private void GoTo(Form next)
        {
            next.Show();
            this.Hide();
        }

        //navigation

        private void btnCoffee_Click(object sender, EventArgs e) => GoTo(new Coffee());

        private void btnMenu_Click(object sender, EventArgs e) => GoTo(new Menu());

        private void btnFruitTea_Click(object sender, EventArgs e) => GoTo(new FruitTea());

        private void btnCart_Click(object sender, EventArgs e) => GoTo(new Cart());

        private void btnRiceMeal_Click(object sender, EventArgs e) => GoTo(new Rice_Meal());

        private void btnPastry_Click(object sender, EventArgs e) => GoTo(new Pastry());

        //add to cart buttons

        private void btnAddToCartAmer_Click(object sender, EventArgs e)
        {
            AddDrinkToCart("Wintermelon", rbtnSmallWinter, rbtnLargeWinter, txtQtyWinter, 89m, 99m);
        }

        private void btnAddtoCartOki_Click(object sender, EventArgs e)
        {
            AddDrinkToCart("Okinawa", rbtnSmallOki, rbtnLargeOki, txtQtyOkinawa, 89m, 99m);
        }

        private void btnAddtoCartCandC_Click(object sender, EventArgs e)
        {
            AddDrinkToCart("Cookies and Cream", rbtnSmallCandC, rbtnLargeCandC, txtQtyCandC, 89m, 99m);
        }

        private void btnAddtoCartSaltCarm_Click(object sender, EventArgs e)
        {
            AddDrinkToCart("Salted Caramel", rbtnSmallSaltCarm, rbtnLargeSaltCarm, txtQtySaltCarm, 89m, 99m);
        }

        private void btnAddtoCartHokaido_Click(object sender, EventArgs e)
        {
            AddDrinkToCart("Hokkaido", rbtnSmallHokaido, rbtnLargeHokaido, txtQtyHokk, 89m, 99m);
        }

        private void btnAddtoCartThai_Click(object sender, EventArgs e)
        {
            AddDrinkToCart("Thai", rbtnSmallThai, rbtnLargeThai, txtQtyThai, 89m, 99m);
        }

        private void btnAddtoCartMatcha_Click(object sender, EventArgs e)
        {
            AddDrinkToCart("Matcha", rbtnSmallMatcha, rbtnLargeMatcha, txtQtyMatcha, 89m, 99m);
        }
    }
}
