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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            Analytics analytics = new Analytics();
            analytics.Show();  this.Hide();

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(); this.Hide();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Coffee coffee = new Coffee();
            coffee.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        // Auto Resize form to fit the screen (hopefully it works)
        private void Coffee_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMilktea_Click(object sender, EventArgs e)
        {
            MilkTea milkTea = new MilkTea();
            milkTea.Show();
            this.Hide();
        }
    }


}
