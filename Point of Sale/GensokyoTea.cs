using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Point_of_Sale.Data;
using Point_of_Sale.Model;
using System.Collections.Generic;
using System.Linq;

namespace Point_of_Sale
{
    //Users are WIP**
    public partial class GensokyoTea : Form
    {
        private Inventory inventory = new Inventory();
        private List<Tea> shoppingCart = new List<Tea>();

        BindingSource TeaBinding = new BindingSource();
        BindingSource CartBinding = new BindingSource();

        Form q_form = new qtyForm();
        Form d_form = new discountForm();

        string user = "admin";
        public static double subtotal;
        double storeProfit;

        public GensokyoTea()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DbContext.ConnectToDb();

            InitializeUI();

            CreateBindings();
        }

        private void InitializeUI()
        {
            lblTime.Text = Convert.ToString(DateTime.Now);
            lblUser.Text = $"Logged in as {user}";
            txtTotal.Text = string.Format("${0}", 0);
        }

        private void CreateBindings()
        {
            TeaBinding.DataSource = inventory.Teas.Where(x => x.TeaQuantity > 0).ToList();
            teasListBox.DataSource = TeaBinding;

            teasListBox.DisplayMember = "DisplayInfo";
            teasListBox.ValueMember = "DisplayInfo";

            CartBinding.DataSource = shoppingCart;
            cartListBox.DataSource = CartBinding;

            cartListBox.DisplayMember = "CartInfo";
            cartListBox.ValueMember = "CartInfo";
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            shoppingCart.Clear();
            CartBinding.ResetBindings(false);

            subtotal = 0;
            txtTotal.Text = "$0";
        }

        private void btnCompleTxn_Click(object sender, EventArgs e)
        {
            foreach (Tea item in shoppingCart)
            {
                item.TeaQuantity = item.TeaQuantity - 1;
            }

            TeaBinding.DataSource = inventory.Teas.Where(x => x.TeaQuantity > 0).ToList();

            shoppingCart.Clear();

            CartBinding.ResetBindings(false);
            TeaBinding.ResetBindings(false);

            storeProfit += subtotal;
            subtotal = 0;
            txtTotal.Text = "$0";
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            //Work on this once I have finished the actual PoS system.
            DbContext.CloseDb();
            Application.Exit();
        }

        private void btnQuantity_Click(object sender, EventArgs e)
        {
            //Opens a seperate form for the user to enter an amount.
            q_form.Show();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            Tea selectedItem = (Tea)teasListBox.SelectedItem;

            while (qtyForm.quantity > 0)
            {
                shoppingCart.Add(selectedItem);
                subtotal += selectedItem.TeaPrice;
                qtyForm.quantity -= 1;

            }

            qtyForm.quantity = 1;

            txtTotal.Text = String.Format("${0}", subtotal.ToString());

            TeaBinding.DataSource = inventory.Teas.Where(x => x.TeaQuantity > 0).ToList();
            CartBinding.ResetBindings(false);
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            d_form.Show();
        }
    }
}
