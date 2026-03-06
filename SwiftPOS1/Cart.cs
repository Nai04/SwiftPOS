using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace SwiftPOS1
{
    public partial class Cart : Form
    {
        PrintDocument printDoc = new PrintDocument();
        int startY = 0;




        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            int y = 20;

            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font textFont = new Font("Arial", 10);

            e.Graphics.DrawString("SwiftPOS Coffee Shop", titleFont, Brushes.Black, 50, y);
            y += 40;

            e.Graphics.DrawString("Item        Qty        Price", textFont, Brushes.Black, 50, y);
            y += 30;

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.IsNewRow) continue;

                string item = row.Cells["ItemName"].Value.ToString();
                string qty = row.Cells["Qty"].Value.ToString();
                string price = row.Cells["Price"].Value.ToString();

                e.Graphics.DrawString($"{item}     {qty}     {price}", textFont, Brushes.Black, 50, y);
                y += 25;
            }

            y += 20;

            decimal total = CartService.Items.Sum(i => i.Price * i.Qty);

            e.Graphics.DrawString($"TOTAL: {total}", titleFont, Brushes.Black, 50, y);
        }

        public Cart()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            dgvCart.AllowUserToAddRows = false;
            dgvCart.ReadOnly = true;
            dgvCart.DataSource = CartService.Items;

            // update total now + whenever cart changes
            UpdateGrandTotal();
            CartService.Items.ListChanged += (s, ev) => UpdateGrandTotal();
            dgvCart.DataSource = CartService.Items;
        }
        private void UpdateGrandTotal()
        {
            decimal grandTotal = CartService.Items.Sum(i => i.Total);
            lblGrandTotal.Text = "₱ " + grandTotal.ToString("0.00");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDoc;
            preview.ShowDialog();
            CartService.Items.Clear();
            dgvCart.Refresh();


        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            CartService.Items.Clear();
            dgvCart.Refresh();
        }
    }
}
