using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftPOS1
{
    public class CartItem
    {
        public string ItemName { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public decimal Total => Price * Qty;
    }
    internal class CartService
    {
        public static BindingList<CartItem> Items { get; } = new BindingList<CartItem>();

        public static void AddItem(string name, string size, decimal price, int qty)
        {
            var existing = Items.FirstOrDefault(x => x.ItemName == name && x.Size == size);

            if (existing != null)
            {
                existing.Qty += qty;
                int index = Items.IndexOf(existing);
                Items.ResetItem(index); // refresh Total
            }
            else
            {
                Items.Add(new CartItem { ItemName = name, Size = size, Price = price, Qty = qty });
            }
        }
    }
}
