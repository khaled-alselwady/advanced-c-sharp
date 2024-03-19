using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Dashboard : Form
    {
        static clsShoppingCartModel _cart = new clsShoppingCartModel();

        public Dashboard()
        {
            InitializeComponent();
            PopulateCartWithDemoDate();
        }

        private static void PopulateCartWithDemoDate()
        {
            _cart.Items.Add(new clsProductModel { ItemName = "Creel", Price = 3.36M });
            _cart.Items.Add(new clsProductModel { ItemName = "Milk", Price = 2.95M });
            _cart.Items.Add(new clsProductModel { ItemName = "Strawberries", Price = 7.51M });
            _cart.Items.Add(new clsProductModel { ItemName = "Blueberries", Price = 8.84M });
        }

        private void PrintOutDiscountAlert(string message)
        {
            MessageBox.Show(message);
        }

        private void PrintSubTotalAlert(decimal subTotal)
        {
            MessageBox.Show($"The subtotal is {subTotal:C2}");
        }

        private decimal CalculateLeveledDiscount(List<clsProductModel> products, decimal subTotal)
        {
            if (products is null) return 0M;

            return subTotal - products.Count;
        }

        private void btnMessageBoxDemo_Click(object sender, EventArgs e)
        {
            decimal total = _cart.GenerateTotal
                (PrintSubTotalAlert, CalculateLeveledDiscount, PrintOutDiscountAlert);

            MessageBox.Show($"The total is {total:C2}");
        }

        private void btnTextBoxDemo_Click(object sender, EventArgs e)
        {
            decimal total = _cart.GenerateTotal(
                (subTotal) => txtSubTotal.Text = $"{subTotal:C2}",
                (products, subTotal) =>
                {
                    if (products is null) return 0M;

                    return subTotal - (products.Count * 2);
                },
                (message) => { }
                );

            txtTotal.Text = $"{total:C2}";
        }
    }
}
