using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_of_Sale
{
    public partial class discountForm : Form
    {
        public static double discount = 1;

        public discountForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            discount = 1;

            ActiveForm.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            discount = 1 - Convert.ToDouble(txtDiscount.Text) / 100;
            GensokyoTea.subtotal = GensokyoTea.subtotal * discount;

            txtDiscount.Text = "";
            discount = 1;

            ActiveForm.Hide();
        }
    }
}
