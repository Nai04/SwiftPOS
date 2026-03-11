using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace SwiftPOS1
{
    public partial class Inventory : Form
    {
        private DataTable inventoryTable = new DataTable();
        private int selectedRowIndex = -1;

        
        private Dictionary<string, string> itemIdMap = new Dictionary<string, string>();

        
        private Dictionary<string, int> categoryCounters = new Dictionary<string, int>()
        {
            { "Bread & Pastries", 1000 },
            { "Coffee & Latte", 2000 },
            { "Milk Tea", 3000 },
            { "Fruit Tea", 4000 },
            { "Rice Meals", 5000 },
            { "Pasta", 6000 },
            { "Snacks", 7000 },
            { "Cups & Packaging", 8000 }
        };

        // category -> items
        private Dictionary<string, List<string>> categoryItems = new Dictionary<string, List<string>>()
        {
            {
                "Coffee & Latte",
                new List<string>
                {
                    "Coffee Beans (Kalinga)",
                    "Coffee Beans (Robusta)",
                    "Emborg Milk",
                    "Blanca Syrup",
                    "Condensed Milk",
                    "Matcha Powder",
                    "Ice",
                    "Water",
                    "16oz Cup for Cold",
                    "22oz Cup for Cold",
                    "8oz Hot",
                    "12oz Hot",
                    "Lids",
                    "Thin Straw"
                }
            },
            {
                "Milk Tea",
                new List<string>
                {
                    "Wintermelon Powder",
                    "Okinawa Powder",
                    "Thai Powder",
                    "Cookies and Cream Powder",
                    "Matcha Powder",
                    "Caramel Powder",
                    "Salted Caramel Powder",
                    "Ersao Pearl",
                    "Tea",
                    "Creamer",
                    "Milktea Straw"
                }
            },
            {
                "Fruit Tea",
                new List<string>
                {
                    "Milin Green Apple Syrup",
                    "Milin Strawberry Syrup",
                    "Milin Blueberry Syrup",
                    "Milin Lychee Syrup",
                    "Milin Mango Syrup",
                    "Milin Peach Syrup",
                    "Milin Nata De Coco",
                    "Milin Rainbow Jelly"
                }
            },
            {
                "Bread & Pastries",
                new List<string>
                {
                    "Dubai Chocolate (Order)",
                    "Chocolate Syrup",
                    "Maple Syrup"
                }
            },
            {
                "Rice Meals",
                new List<string>
                {
                    "Rice",
                    "Garlic",
                    "Oil",
                    "Salt",
                    "Pepper",
                    "CDO Ham",
                    "Purefoods Hotdog",
                    "DALI Shanghai",
                    "DALI Longganisa",
                    "DALI Embotido",
                    "Takeout Box",
                    "Disposable Spoon and Fork",
                    "Take out Plastic",
                    "Tissue"
                }
            },
            {
                "Pasta",
                new List<string>
                {
                    "Linguine Pasta",
                    "Spaghetti Pasta",
                    "Fettucine Pasta",
                    "Bacon",
                    "Garlic",
                    "AP Cream",
                    "Cheese",
                    "Salt",
                    "Pepper",
                    "Filippo Berio Pesto",
                    "Lemon",
                    "Parsley",
                    "Herbs and Spices",
                    "Chili",
                    "Tomato Paste",
                    "Knorr Chicken",
                    "Tuna",
                    "Microwavable Container"
                }
            },
            {
                "Snacks",
                new List<string>
                {
                    "French Fries",
                    "Siomai",
                    "Nachos",
                    "Cheese Powder",
                    "Sour Cream Powder",
                    "BBQ Powder",
                    "Ketchup",
                    "Mayonnaise",
                    "Nacho Chips",
                    "Ground Pork",
                    "Tomato",
                    "Onion",
                    "Calamansi",
                    "Soy Sauce",
                    "Knorr Seasoning",
                    "Siomai Paper Tray",
                    "Toothpick"
                }
            },
            {
                "Cups & Packaging",
                new List<string>
                {
                    "16oz Cup for Cold",
                    "22oz Cup for Cold",
                    "8oz Hot",
                    "12oz Hot",
                    "Lids",
                    "Thin Straw",
                    "Milktea Straw",
                    "Takeout Box",
                    "Disposable Spoon and Fork",
                    "Take out Plastic",
                    "Tissue",
                    "Microwavable Container",
                    "Siomai Paper Tray",
                    "Toothpick"
                }
            }
        };

        public Inventory()
        {
            InitializeComponent();

            LoadCategories();
            SetupTable();

            InvCategory.SelectedIndexChanged += InvCategory_SelectedIndexChanged;
            InvItemName.SelectedIndexChanged += InvItemName_SelectedIndexChanged;
            InvDataGridView.CellClick += InvDataGridView_CellClick;
            InvSearch.TextChanged += InvSearch_TextChanged;
        }

        private void LoadCategories()
        {
            InvCategory.Items.Clear();

            foreach (string category in categoryItems.Keys)
            {
                InvCategory.Items.Add(category);
            }
        }

        private void SetupTable()
        {
            inventoryTable.Columns.Add("Item ID");
            inventoryTable.Columns.Add("Item Name");
            inventoryTable.Columns.Add("Category");
            inventoryTable.Columns.Add("Quantity", typeof(int));
            inventoryTable.Columns.Add("Purchase Price", typeof(decimal));
            inventoryTable.Columns.Add("Stock", typeof(int));

            inventoryView = new DataView(inventoryTable);

            InvDataGridView.Columns.Clear();
            InvDataGridView.AutoGenerateColumns = true;
            InvDataGridView.DataSource = inventoryView;
        }

        private string GetItemKey()
        {
            return InvCategory.Text.Trim() + "|" + InvItemName.Text.Trim();
        }

        private string GenerateCategoryID(string category)
        {
            if (!categoryCounters.ContainsKey(category))
                return "";

            categoryCounters[category]++;
            return categoryCounters[category].ToString();
        }

        private void InvCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            InvItemName.Items.Clear();
            InvItemName.Text = "";
            InvItemId.Text = "";

            if (categoryItems.ContainsKey(InvCategory.Text))
            {
                foreach (string item in categoryItems[InvCategory.Text])
                {
                    InvItemName.Items.Add(item);
                }
            }

            if (InvItemName.Items.Count > 0)
                InvItemName.SelectedIndex = 0;
        }

        private void InvItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InvCategory.Text) || string.IsNullOrWhiteSpace(InvItemName.Text))
                return;

            string itemKey = GetItemKey();

            if (itemIdMap.ContainsKey(itemKey))
            {
                InvItemId.Text = itemIdMap[itemKey];
            }
            else
            {
                InvItemId.Text = GeneratePreviewID(InvCategory.Text);
            }
        }

        private string GeneratePreviewID(string category)
        {
            if (!categoryCounters.ContainsKey(category))
                return "";

            return (categoryCounters[category] + 1).ToString();
        }

        private bool ItemAlreadyExists(string itemKey)
        {
            foreach (DataRow row in inventoryTable.Rows)
            {
                string existingKey = row["Category"].ToString() + "|" + row["Item Name"].ToString();
                if (existingKey == itemKey)
                    return true;
            }
            return false;
        }

        private void btnInvAdd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InvItemName.Text) ||
                string.IsNullOrWhiteSpace(InvCategory.Text) ||
                string.IsNullOrWhiteSpace(InvQuantity.Text) ||
                string.IsNullOrWhiteSpace(InvPrice.Text) ||
                string.IsNullOrWhiteSpace(InvStock.Text))
            {
                MessageBox.Show("Please fill in all fields first.");
                return;
            }

            int quantity;
            decimal price;
            int stock;

            if (!int.TryParse(InvQuantity.Text, out quantity))
            {
                MessageBox.Show("Quantity must be a number.");
                return;
            }

            if (!decimal.TryParse(InvPrice.Text, out price))
            {
                MessageBox.Show("Purchase Price must be a number.");
                return;
            }

            if (!int.TryParse(InvStock.Text, out stock))
            {
                MessageBox.Show("Stock must be a number.");
                return;
            }

            string itemKey = GetItemKey();

            if (ItemAlreadyExists(itemKey))
            {
                MessageBox.Show("This item is already added.");
                return;
            }

            string itemID;

            if (itemIdMap.ContainsKey(itemKey))
            {
                itemID = itemIdMap[itemKey];
            }
            else
            {
                itemID = GenerateCategoryID(InvCategory.Text);
                itemIdMap[itemKey] = itemID;
            }

            DataRow row = inventoryTable.NewRow();
            row["Item ID"] = itemID;
            row["Item Name"] = InvItemName.Text;
            row["Category"] = InvCategory.Text;
            row["Quantity"] = quantity;
            row["Purchase Price"] = price;
            row["Stock"] = stock;

            inventoryTable.Rows.Add(row);

            MessageBox.Show("Item added successfully.");
            ClearFields();
        }

        private void btnInvDelete_Click_1(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0 && selectedRowIndex < inventoryTable.Rows.Count)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this item?",
                    "Delete Item",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    inventoryTable.Rows.RemoveAt(selectedRowIndex);
                    selectedRowIndex = -1;
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
        }

        private void btnInvUpdate_Click_1(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0 && selectedRowIndex < inventoryTable.Rows.Count)
            {
                int quantity;
                decimal price;
                int stock;

                if (!int.TryParse(InvQuantity.Text, out quantity))
                {
                    MessageBox.Show("Quantity must be a number.");
                    return;
                }

                if (!decimal.TryParse(InvPrice.Text, out price))
                {
                    MessageBox.Show("Purchase Price must be a number.");
                    return;
                }

                if (!int.TryParse(InvStock.Text, out stock))
                {
                    MessageBox.Show("Stock must be a number.");
                    return;
                }

                inventoryTable.Rows[selectedRowIndex]["Item Name"] = InvItemName.Text;
                inventoryTable.Rows[selectedRowIndex]["Category"] = InvCategory.Text;
                inventoryTable.Rows[selectedRowIndex]["Quantity"] = quantity;
                inventoryTable.Rows[selectedRowIndex]["Purchase Price"] = price;
                inventoryTable.Rows[selectedRowIndex]["Stock"] = stock;

                MessageBox.Show("Item updated successfully.");

                selectedRowIndex = -1;
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
        }

        private void InvDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;

                InvItemId.Text = InvDataGridView.Rows[e.RowIndex].Cells[0].Value?.ToString();
                InvItemName.Text = InvDataGridView.Rows[e.RowIndex].Cells[1].Value?.ToString();
                InvCategory.Text = InvDataGridView.Rows[e.RowIndex].Cells[2].Value?.ToString();
                InvQuantity.Text = InvDataGridView.Rows[e.RowIndex].Cells[3].Value?.ToString();
                InvPrice.Text = InvDataGridView.Rows[e.RowIndex].Cells[4].Value?.ToString();
                InvStock.Text = InvDataGridView.Rows[e.RowIndex].Cells[5].Value?.ToString();
            }
        }

        private void ClearFields()
        {
            InvItemId.Text = "";
            InvItemName.SelectedIndex = -1;
            InvItemName.Text = "";
            InvCategory.SelectedIndex = -1;
            InvQuantity.Clear();
            InvPrice.Clear();
            InvStock.Clear();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
        }

        private void InvStock_Click(object sender, EventArgs e)
        {
        }

        private DataView inventoryView;

        private void ApplySearchFilter()
        {
            string keyword = InvSearch.Text.Trim().Replace("'", "''");

            if (string.IsNullOrWhiteSpace(keyword))
            {
                inventoryView.RowFilter = "";
            }
            else
            {
                inventoryView.RowFilter =
                    $"Convert([Item ID], 'System.String') LIKE '%{keyword}%' OR " +
                    $"[Item Name] LIKE '%{keyword}%' OR " +
                    $"Category LIKE '%{keyword}%'";
            }
        }
        private void InvSearch_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }
    }
}