using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tblContactsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblContactsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contactsDataSet);

        }

        private void My_Contacts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactsDataSet.tblContacts' table. You can move, or remove it, as needed.
            this.tblContactsTableAdapter.Fill(this.contactsDataSet.tblContacts);

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //show all records
            this.tblContactsTableAdapter.Fill(this.contactsDataSet.tblContacts);
            txtName.Clear();
        }

        private void btnQurey_Click(object sender, EventArgs e)
        {
            // show records by name
            this.tblContactsTableAdapter.FillByName(this.contactsDataSet.tblContacts,txtName.Text);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            // make sure a row is selected
            if (tblContactsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a contact to view");
            }
            else
            { 
                // get id of contact
                int intID = int.Parse(tblContactsDataGridView.CurrentRow.Cells[0].Value.ToString());
                // show details form
                frmDetails DetailsForm = new frmDetails(intID);
                DetailsForm.ShowDialog();
                // clear out text box
                txtName.Clear();
                // show all records
                this.tblContactsTableAdapter.Fill(this.contactsDataSet.tblContacts);
                txtName.Clear();
            }

        }
    }
}
