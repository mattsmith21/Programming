using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace MyFinalProject
{
    public partial class frmAddTicket : Form
    {
        public frmAddTicket(int intID2)
        {
            InitializeComponent();
            creation_DateDateTimePicker.Value = DateTime.Now;

        }

        private void btnAddTic_Click(object sender, EventArgs e)
        {
            // store textboxes
            string sub = subjectTextBox.Text;
            string requester = requesterTextBox.Text;
            string assigned = assigned_ToTextBox.Text;
            string date = creation_DateDateTimePicker.Value.ToString("MM/dd/yyyy");
            string prio = priorityTextBox.Text;
            // save what was stored
            this.tblTicketsTableAdapter.InsertQuery(sub, requester, assigned, date, prio);
            // close form
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // close form
            this.Close();
        }

        private void tblTicketsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblTicketsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ticketsDataSet);

        }

        private void frmAddTicket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticketsDataSet.tblTickets' table. You can move, or remove it, as needed.
            this.tblTicketsTableAdapter.Fill(this.ticketsDataSet.tblTickets);

        }

        private void creation_DateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
