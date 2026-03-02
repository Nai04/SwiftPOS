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

        private void btnRiceMeal_Click(object sender, EventArgs e)
        {
            Rice_Meal rice_Meal = new Rice_Meal();
            rice_Meal.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
           Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Hide();
        }

        private void btnSnacksPasta_Click(object sender, EventArgs e)
        {
            SnacksPasta snacksPasta = new SnacksPasta();
            snacksPasta.Show();
            this.Hide();
        }
    }
}
