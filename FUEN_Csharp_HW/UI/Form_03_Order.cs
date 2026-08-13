using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FUEN_Csharp_HW.UI
{
    public partial class Form_03_Order : Form
    {
        private class SaleItem
        {
            public int ItemId { get; set; }
            public string ItemChName { get; set; }
            public string ItemEnName { get; set; }
            public int UnitPrice { get; set; }

            public SaleItem(int itemId, string itemChName, string itemEnName, int price)
            {
                ItemId = itemId;
                ItemChName = itemChName;
                ItemEnName = itemEnName;
                UnitPrice = price;
            }
        }

        private class OrderItem
        {
            public int ItemId { get; set; }
            public string ItemChName { get; set; }
            public string ItemEnName { get; set; }
            public int Quantity { get; set; } = 0;
            public int UnitPrice { get; set; }
            public int TotalPrice => Quantity * UnitPrice;
            public string DisplayText => $"{ItemChName}{ItemEnName} x{Quantity},共NT$ {TotalPrice} 元\n";

            public OrderItem(SaleItem saleItem, int count = 0)
            {
                ItemId = saleItem.ItemId;
                ItemChName = saleItem.ItemChName;
                ItemEnName = saleItem.ItemEnName;
                UnitPrice = saleItem.UnitPrice;
            }

            public void Add(int count)
            {
                Quantity += count;
            }

            public void Remove(int count)
            {
                Quantity -= count;
                if (Quantity < 0) Quantity = 0;
            }
        }

        private class Order
        {
            private Dictionary<int, OrderItem> _cart = new Dictionary<int, OrderItem>();


            public int TotalPrice
            {
                get
                {
                    int total = 0;

                    if (_cart.Count > 0)
                    {
                        foreach (KeyValuePair<int, OrderItem> pair in _cart)
                            total += pair.Value.TotalPrice;
                    }
                    return total;
                }
            }

            public string DisplayText
            {
                get
                {
                    if (_cart.Count < 1)
                        return "尚未點餐";

                    StringBuilder builder = new StringBuilder();
                    foreach (var pair in _cart)
                        builder.Append(pair.Value.DisplayText);

                    return builder.ToString();
                }
            }

            public void Add(SaleItem saleItem, int amount)
            {
                if (!_cart.TryGetValue(saleItem.ItemId, out OrderItem orderItem))
                {
                    orderItem = new OrderItem(saleItem);
                    _cart.Add(saleItem.ItemId, orderItem);
                }

                orderItem.Add(amount);
            }

            public void Clear()
            {
                _cart.Clear();
            }
        }

        private Dictionary<int, SaleItem> saleList = new Dictionary<int, SaleItem>();
        private Order order = new Order();


        public Form_03_Order()
        {
            InitializeComponent();
            InitializeSaleItem();
        }

        private void InitializeSaleItem()
        {
            saleList.Add(1, new SaleItem(1, "啤酒", "Beer", 120));
            saleList.Add(2, new SaleItem(2, "龍舌蘭", "Tequila", 180));
            saleList.Add(3, new SaleItem(3, "威士忌", "Whisky", 350));
            saleList.Add(4, new SaleItem(4, "紅酒", "Wine", 320));
        }

        private void btnBeer_Click(object sender, EventArgs e)
        {
            AddOrder(1, 1);
        }

        private void btnWhisky_Click(object sender, EventArgs e)
        {
            AddOrder(2, 1);
        }

        private void btnTequila_Click(object sender, EventArgs e)
        {
            AddOrder(3, 1);
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            AddOrder(4, 1);
        }

        private void AddOrder(int id, int count)
        {
            if (!saleList.TryGetValue(id, out SaleItem item))
                return;

            order.Add(item, count);
            RefreshOrderList();
        }


        private void OnBtnClear_Click(object sender, EventArgs e)
        {
            order.Clear();
            RefreshOrderList();
        }

        private void OnBtnCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"NT$ {order.TotalPrice}元");
        }

        private void OnBtnCreditCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"NT$ {order.TotalPrice * 0.9m}元");
        }

        private void RefreshOrderList()
        {
            labelPrice.Text = $"NT$ {order.TotalPrice}";
            labelOrderList.Text = order.DisplayText;
        }
    }
}
