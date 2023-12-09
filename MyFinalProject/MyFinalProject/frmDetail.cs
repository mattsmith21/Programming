using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinalProject
{
    public partial class frmDetail : Form
    {
        int _IntID;

        public frmDetail(int IntID)
        {
            _IntID = IntID;
            InitializeComponent();
        }

        private void subjectTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void requesterTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void assigned_ToTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void creation_DateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void priorityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }

        private void tblTicketsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblTicketsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ticketsDataSet);

        }

        private void frmDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticketsDataSet.tblTickets' table. You can move, or remove it, as needed.
            this.tblTicketsTableAdapter.FillByID(this.ticketsDataSet.tblTickets, _IntID);

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // save the changes
            this.Validate();
            this.tblTicketsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ticketsDataSet);
            this.Close();
        }
    }
}
