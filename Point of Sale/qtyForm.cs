using System;
using System.Windows.Forms;

namespace Point_of_Sale
{
    public partial class qtyForm : Form
    {

        public qtyForm()
        {
            InitializeComponent();
        }

        public static int quantity = 1;

        private void btnConfirmQty_Click(object sender, EventArgs e)
        {
            quantity = Convert.ToInt32(txtQuantity.Text);

            txtQuantity.Text = "";

            ActiveForm.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = "";
            ActiveForm.Hide();
        }
    }
}
