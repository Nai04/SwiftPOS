using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiticoneNetFrameworkUI;
using System.Windows.Forms;

namespace SwiftPOS1
{
    public partial class Coffee : Form
    {
        public Coffee()
        {
            InitializeComponent();
        }

        // Size class
        private bool TryGetSize(SiticoneRadioButton smallBtn,SiticoneRadioButton largeBtn,out string size)
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

            MessageBox.Show("Please select a size (Small or Large).", "Missing Size",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        // Quantity class/logic
        private bool TryGetQty(SiticoneTextBoxAdvanced qtyBox, out int qty)
        {
            qty = 0;
            string qtyText = qtyBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(qtyText))
            {
                MessageBox.Show("Please enter quantity.", "Missing Quantity",
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
        // Add to cart logic/class
        private void AddDrinkToCart(string itemName,SiticoneRadioButton smallBtn,SiticoneRadioButton largeBtn,SiticoneTextBoxAdvanced qtyBox,decimal smallPrice,decimal largePrice)
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



        private void siticoneButton1_Click(object sender, EventArgs e)
        {

            AddDrinkToCart("Americano", rbtnSmallAmer, rbtnLargeAmer, txtQuantityAmer, 89m, 99m);
        }

        private void btnAddtoCartCapp_Click(object sender, EventArgs e)
        {
            AddDrinkToCart("Cappuccino", rbtnSmallCapp, rbtnLargeCapp, txtQtyCapp, 89m, 99m);
        }

        private void btnAddToCartHChoc_Click(object sender, EventArgs e)
        {
            AddDrinkToCart("Hot Choco", rbtnSmallHChoc, rbtnLargeHChoc, txtQuantityHChoc, 89m, 99m);
        }

        private void btnAddToCartHLatte_Click(object sender, EventArgs e)
        {
            AddDrinkToCart("Hot Latte", rbtnSmallHotLatte, rbtnLargeHotLatte, txtQtyHLatte, 89m, 99m);
        }

        private void btnAddToCartSpaLattte_Click(object sender, EventArgs e)
        {
            AddDrinkToCart("Spanish Latte", rbtnSmallSpaLatte, rbtnLargeSpaLatte, txtQtySpaLatte, 89m, 99m);
        }

        private void btnAddToCartHMocLatte_Click(object sender, EventArgs e)
        {
            AddDrinkToCart("Hot Mocha Latte", rbtnSmallHMochLatte, rbntLargeHMochaLatte, txtQtyHMochaLatte, 89m, 99m);
        }

        private void btnAddToCartIceLatte_Click(object sender, EventArgs e)
        {
            AddDrinkToCart("Iced Latte", rbtnSmallIcedLatte, rbtnLargeIcedLatte, txtQtyIcedLatte, 89m, 99m);
        }

        private void btnAddToCartIcedMochLatte_Click(object sender, EventArgs e)
        {
            AddDrinkToCart("Iced Mocha Latte", rbtnSmallIcedMochaLatte, rbtnLargeIcedMochaLatte, txtQtyIcedMochaLatte, 89m, 99m);
        }


        private void btnCart_Click(object sender, EventArgs e) => GoTo(new Cart());

        private void btnMilktea_Click(object sender, EventArgs e) => GoTo(new MilkTea());

        private void btnFruitTea_Click(object sender, EventArgs e) => GoTo(new FruitTea());

        private void btnMenu_Click(object sender, EventArgs e) => GoTo(new Menu());

        private void btnRiceMeal_Click(object sender, EventArgs e) => GoTo(new Rice_Meal());

        private void btnPastry_Click(object sender, EventArgs e) => GoTo(new Pastry());


        private void btnLogout_Click(object sender, EventArgs e) => GoTo(new Form1());



        private void btnCoffee_Click(object sender, EventArgs e) 
        { 

        }
        private void siticoneTextBoxAdvanced1_TextContentChanged(object sender, EventArgs e) 
        {
            
        }
        private void Coffee_Load(object sender, EventArgs e) 
        {

        }
    }
}
