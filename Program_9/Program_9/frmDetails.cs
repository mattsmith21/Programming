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
    public partial class frmDetails : Form
    {
        int _ContactID;
        public frmDetails(int ContactID)
        {
            _ContactID = ContactID;
            InitializeComponent();
        }

        private void tblContactsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblContactsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contactsDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactsDataSet.tblContacts' table. You can move, or remove it, as needed.
            this.tblContactsTableAdapter.FillByID(this.contactsDataSet.tblContacts,_ContactID);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // save the changes
            this.Validate();
            this.tblContactsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contactsDataSet);
            // close the form
            this.Close();
        }

        private void frmDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactsDataSet1.tblContacts' table. You can move, or remove it, as needed.
            this.tblContactsTableAdapter1.Fill(this.contactsDataSet1.tblContacts);
            // TODO: This line of code loads data into the 'contactsDataSet1.tblContacts' table. You can move, or remove it, as needed.
            this.tblContactsTableAdapter1.Fill(this.contactsDataSet1.tblContacts);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            // validate data was entered
            if (lastNameTextBox.Text == "")
            {
                MessageBox.Show("Enter a Last name.");
                lastNameTextBox.Focus();
            }
            else if (firstNameTextBox.Text == "")
            {
                MessageBox.Show("Enter a First name.");
                firstNameTextBox.Focus();
            }
            else if (streetTextBox.Text == "")
            {
                MessageBox.Show("Enter a street.");
                streetTextBox.Focus();
            }
            else if (cityTextBox.Text == "")
            {
                MessageBox.Show("Enter a city.");
                cityTextBox.Focus();
            }
            else if (stateTextBox.Text == "")
            {
                MessageBox.Show("Enter a state.");
                stateTextBox.Focus();
            }
            else if (zipTextBox.Text.Length < 5)
            {
                MessageBox.Show("Enter a Zip code.");
                zipTextBox.Focus();
            }
            else
            {
                // save the changes
                this.Validate();
                this.tblContactsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.contactsDataSet);
                // close the form
                this.Close();
            }

        }
    }
}
