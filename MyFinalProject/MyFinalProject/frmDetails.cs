using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyFinalProject.TicketsDataSet;

namespace MyFinalProject
{
    public partial class frmDetails : Form
    {
        int _TicketID;

        public frmDetails(int TicketID)
        {
            _TicketID = TicketID;
            InitializeComponent();
            

        }

        private void tblTicketsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblTicketsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ticketsDataSet);

        }

        private void frmDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticketsDataSet.tblTickets' table. You can move, or remove it, as needed.
            this.tblTicketsTableAdapter.FillByID(this.ticketsDataSet.tblTickets, _TicketID);

        }

        private void ticket_IDLabel_Click(object sender, EventArgs e)
        {

        }

        private void ticket_IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // show Tickets form
            frmDetails DetailsForm = new frmDetails(2);
            frmTickets TicketsForm = new frmTickets();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate data was entered
            if (ticket_IDTextBox.Text == "")
            {
                MessageBox.Show("Enter a Ticket ID");
                ticket_IDTextBox.Focus();
            }
            else if (subjectTextBox.Text == "")
            {
                MessageBox.Show("Enter a subject");
                subjectTextBox.Focus();
            }
            else if (requesterTextBox.Text == "")
            {
                MessageBox.Show("Enter a Requester");
                requesterTextBox.Focus();
            }
            else if (assigned_ToTextBox.Text == "")
            {
                MessageBox.Show("Enter an assigned to");
                assigned_ToTextBox.Focus();
            }
            else if (creation_DateTextBox.Text == "")
            {
                MessageBox.Show("Enter a creation date");
                creation_DateTextBox.Focus();
            }
            else if (priorityTextBox.Text == "")
            {
                MessageBox.Show("Enter a priority");
                priorityTextBox.Focus();
            }

            this.Validate();
            this.tblTicketsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ticketsDataSet);

            // close the form
            this.Close();
        }
    }
}
