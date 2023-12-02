using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modual_7
{
    public partial class Form1 : Form
    {
        List<double> intScores = new List<double>() { 50, 40, 30, 20 }; 
        

        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayClassInformation()
        {

            //create varibles
            double dblHigh = 0;
            double dblLow = 0;
            double dblAve = 0;
            //get average
            dblHigh = intScores.Max();
            dblLow = intScores.Min();
            dblAve = intScores.Average();
            //display to screen
            lblHigh.Text = dblHigh.ToString();
            lblLow.Text = dblLow.ToString();
            lblAve.Text = dblAve.ToString();
             
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstStudents_DoubleClick(object sender, EventArgs e)
        {
           DisplayClassInformation();
            
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            //verify an item was selected
            if (lstStudents.SelectedItems.Count > -1)
            {
                //remove item from list
                intScores.RemoveAt(lstStudents.SelectedIndex);
                //remove item from listbox
                lstStudents.Items.RemoveAt(lstStudents.SelectedIndex);
            }
            DisplayClassInformation();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //make groupbox visable 
            grpStudent.Visible = true;
            //set tag to "A"
            grpStudent.Tag = "A";
            //clear all controls
            txtStudent.Clear();
            numScore.Value = 0;
            //set focus to name
            txtStudent.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //hide 
            grpStudent.Visible=false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //check if edit or add
            if (grpStudent.Tag == "A")
            {
                lstStudents.Items.Add(txtStudent.Text);
                intScores.Add(Convert.ToDouble(numScore.Value));
            }
            else
            {
                //get valuse and place in listbox and list
                lstStudents.Items[lstStudents.SelectedIndex] = txtStudent.Text;
                intScores[lstStudents.SelectedIndex] = Convert.ToDouble(numScore.Value);
            }
            DisplayClassInformation();
            //hide group box
            grpStudent.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //verify something was selected
            if (lstStudents.SelectedIndex > -1)
            {
                //display name in textbox and price in numeric up down
                txtStudent.Text = lstStudents.Items[lstStudents.SelectedIndex].ToString();
                numScore.Value = Convert.ToDecimal(intScores[lstStudents.SelectedIndex].ToString());
                //set tag to E
                grpStudent.Tag = "E";
                //display group box
                grpStudent.Visible = true;
                //focus on textbox 
                txtStudent.Focus();

            }
        }
    }
}
