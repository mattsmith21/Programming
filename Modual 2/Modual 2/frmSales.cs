using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modual_2
{
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Create variables and constants 
            const double dblTaxPrecent = 0.06;
            const double dblDeliveryPrice = 6.75;
            double dblSubtotal = 0;
            double dblTax = 0.06;
            double dblDelivery = 6.75;
            double dblTotal = 0;

            // get input from user
            dblSubtotal = Convert.ToDouble(txtSubtotal.Text);
            // calculate values
            dblTax = dblSubtotal * dblTaxPrecent;
            dblTotal = dblSubtotal + dblTax + dblDelivery;
            // display output 
            lblTax.Text = "$" + dblTax.ToString("N2");
            lblDelivery.Text = "$" + dblDelivery.ToString("N2");
            lblTotal.Text = "$" + dblTotal.ToString("N2");



        }
    }
}
