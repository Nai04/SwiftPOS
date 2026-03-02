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

        private void Rice_Meal_Load(object sender, EventArgs e)
        {

        }

        private void rbtnLargeAmer_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToCartAmer_Click(object sender, EventArgs e)
        {

        }

        private void rbtnSmallAmer_Click(object sender, EventArgs e)
        {

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
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
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
