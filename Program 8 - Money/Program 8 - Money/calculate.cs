using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_8___Money
{
    public partial class calculate : Form
    {
        List<clsEmployee> myEmployees = new List<clsEmployee>();
        public calculate()
        {
            InitializeComponent();
        }

        int HoursPerYear = 0;
        int AnnualPay = 0;

        private void calculate_Load(object sender, EventArgs e)
        {

        }

        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            // display movie info in groupbox
            if (lstEmployees.SelectedIndex == -1)
            {
                txtFirst.Clear();
                txtLast.Clear();
                numRate.Value = 0;
                numHours.Value = 0;
            }
            else
            {
                txtFirst.Text = myEmployees[lstEmployees.SelectedIndex].FirstName;
                txtLast.Text = myEmployees[lstEmployees.SelectedIndex].LastName;
                numHours.Text = myEmployees[lstEmployees.SelectedIndex].WeeklyHours.ToString();
                numRate.Text = myEmployees[lstEmployees.SelectedIndex].Rate.ToString();
                txtHoursPerYr.Text = myEmployees[lstEmployees.SelectedIndex].AnnualHours.ToString();
                txtPayPerYr.Text = myEmployees[lstEmployees.SelectedIndex].AnnualRate.ToString();

            }
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // enable grpbox
            grpDetails.Enabled = true;
            lstEmployees.Enabled = false;
            // clear controls
            numRate.Value= 0;
            numHours.Value= 0;
            txtFirst.Clear();
            txtLast.Clear();
            txtHoursPerYr.Clear();
            txtPayPerYr.Clear();
            // set tag to A
            btnAdd.Tag = "A";
            // select txtlast
            txtLast.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            // verify something was selected
            if (myEmployees.Count > 0 && lstEmployees.SelectedIndex > -1)
            {
                // display movie in grpbox
                txtFirst.Text = myEmployees[lstEmployees.SelectedIndex].FirstName;
                txtLast.Text = myEmployees[lstEmployees.SelectedIndex].LastName;
                numRate.Value = Convert.ToDecimal(myEmployees[lstEmployees.SelectedIndex].Rate);
                numHours.Value = Convert.ToDecimal(myEmployees[lstEmployees.SelectedIndex].WeeklyHours);

                // enable grpbox
                lstEmployees.Enabled = false;
                grpDetails.Enabled = true;
                btnAdd.Tag = "E";
                // set focus to movie titles
                txtFirst.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // verify something was selected
            if (lstEmployees.SelectedIndex > -1)
            {
                // delete the movie
                myEmployees.RemoveAt(lstEmployees.SelectedIndex);
                
                // refresh the list
                DisplayEmployees();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // validate information
            if (txtFirst.Text == "")
            {
                MessageBox.Show("Enter a First name");
                txtFirst.Focus();
            }
            else if (txtLast.Text == "")
            {
                MessageBox.Show("Enter an Last Name");
                txtLast.Focus();
            }
            else if (numRate.Value == 0)
            {
                MessageBox.Show("Enter quantity of rate");
                numRate.Focus();
            }
            else if (numHours.Text == "")
            {
                MessageBox.Show("Enter a hourly hours");
                numHours.Focus();
            }
            else
            {
                // create structure for data 
                clsEmployee tempEmpoyee = new clsEmployee(txtLast.Text, txtFirst.Text, (double)numRate.Value, (double)numHours.Value);
                
                // check for add or edit
                if (btnAdd.Tag.ToString() == "A")
                {
                    myEmployees.Add(tempEmpoyee);
                }
                else
                {
                    myEmployees[lstEmployees.SelectedIndex] = tempEmpoyee;
                }
                // handle form
                lstEmployees.Enabled = true;
                grpDetails.Enabled = false;
                DisplayEmployees();
            }
        }
        private void DisplayEmployees ()
        {
            // clear cbobox
            lstEmployees.Items.Clear();
            // loop through 
            for (int i = 0; i < myEmployees.Count; i++)
            {
                lstEmployees.Items.Add(myEmployees[i].LastName + ", " + myEmployees[i].FirstName);
            }
            // set selected index to first apartment
            if (lstEmployees.Items.Count > 0) { lstEmployees.SelectedIndex = 0; }
            else
            {
                // no titles, clear details
                txtFirst.Clear();
                txtLast.Clear();
                lstEmployees.Items.Clear();
                numRate.Value = 0;
                numHours.Value = 0;
                txtHoursPerYr.Clear();
                txtPayPerYr.Clear();

            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // disable detials
            grpDetails.Enabled = false;
            lstEmployees.Enabled = true;
        }
    }

    public class clsEmployee
    {
        // Properties
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public double WeeklyHours { get; set; }
        public double Rate { get; set; }

        public clsEmployee()
        {
            // Constructor with 0 arguments
            LastName = "";
            FirstName = "";
            WeeklyHours = 0;
            Rate = 0;
        }

        public clsEmployee(string lastname, string firstname, double hourlyrate, double weeklyhours)
        {
            // Constructor with 4 arguments
            LastName = lastname;
            FirstName = firstname;
            WeeklyHours = weeklyhours;
            Rate = hourlyrate;
        }

        // Readonly property, WeeklyHours * 52
        public double AnnualHours
        {
            get { return WeeklyHours * 52; }
        }

        // calculation for overtime pay
        public double AnnualRate
        {
            get
            {
                if (WeeklyHours <= 40)
                {
                    return (WeeklyHours * Rate)*52;
                }
                else
                {
                    double regularPay = 40 * Rate;
                    double overtimePay = (WeeklyHours - 40) * 1.5 * Rate;
                    return (regularPay + overtimePay)*52;
                }
            }
        }
    }


}
