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
    public partial class frmTickets : Form
    {
        

        public frmTickets()
        {
            InitializeComponent();
        }

        private void tblTicketsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblTicketsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ticketsDataSet);

        }

        private void frmTickets_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticketsDataSet.tblTickets' table. You can move, or remove it, as needed.
            this.tblTicketsTableAdapter.Fill(this.ticketsDataSet.tblTickets);

        }

        private void tblTicketsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //show record by Subject
            this.tblTicketsTableAdapter.FillBySubject(this.ticketsDataSet.tblTickets, txtSearch.Text);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            // show all records 
            this.tblTicketsTableAdapter.Fill(this.ticketsDataSet.tblTickets);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            // make sure a row is selected
            if (tblTicketsDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Select a ticket");
            }
            else{

            // get UID of ticket
            int intID = int.Parse(tblTicketsDataGridView.CurrentRow.Cells[0].Value.ToString());
            // show detail frm
            frmDetails DetailsForm = new frmDetails(intID);
            DetailsForm.ShowDialog();
                // clear out text box
                txtSearch.Clear();
            // show all records 
            this.tblTicketsTableAdapter.Fill(this.ticketsDataSet.tblTickets);
            }// end else
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //show record by Subject
            this.tblTicketsTableAdapter.FillBySubject(this.ticketsDataSet.tblTickets, txtSearch.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}
