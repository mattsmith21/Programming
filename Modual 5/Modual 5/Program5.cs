using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modual_5
{
    public partial class Program5 : Form
    {
        public Program5()
        {
            InitializeComponent();
        }
        void MovePumpkin(int jumps, string direction)
        {
            //Method that moves the great pumpkin
            switch (direction)
            {
                case "LEFT":
                    picGreatPumpkin.Left -= jumps; break;
                case "RIGHT":
                    picGreatPumpkin.Left += jumps; break;
                case "UP":
                    picGreatPumpkin.Top -= jumps; break;
                case "DOWN":
                    picGreatPumpkin.Top += jumps; break;
            }
        }
        bool PumpkinPatch()
        {
            if (picGreatPumpkin.Left + picGreatPumpkin.Width < picPatch.Left)
                return false;
            if (picPatch.Left + picPatch.Width < picGreatPumpkin.Left)
                return false;
            if (picGreatPumpkin.Top + picGreatPumpkin.Height < picPatch.Top)
                return false;
            if (picPatch.Top + picPatch.Height < picGreatPumpkin.Top)
                return false;

            // SOMETHING COLLIDED!
            return true;
        }
     
        private void picGreatPumpkin_Click(object sender, EventArgs e)
        {
            

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int jumps;
            jumps = (int)numDistance.Value;
            MovePumpkin(jumps, "UP");

            if (PumpkinPatch())
            {
                MessageBox.Show("Way to Go! You helped the Great Pumpkin find the most sincere\r\npumpkin patch!");
            }


            }

        private void btnRight_Click(object sender, EventArgs e)
        {
            int jumps;
            jumps = (int)numDistance.Value;
            MovePumpkin(jumps, "RIGHT");

            if (PumpkinPatch())
            {
                MessageBox.Show("Way to Go! You helped the Great Pumpkin find the most sincere\r\npumpkin patch!");
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int jumps;
            jumps = (int)numDistance.Value;
            MovePumpkin(jumps, "DOWN");

            if (PumpkinPatch())
            {
                MessageBox.Show("Way to Go! You helped the Great Pumpkin find the most sincere\r\npumpkin patch!");
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            int jumps;
            jumps = (int)numDistance.Value;
            MovePumpkin(jumps, "LEFT");

            if (PumpkinPatch())
            {
                MessageBox.Show("Way to Go! You helped the Great Pumpkin find the most sincere\r\npumpkin patch!");
            }
        }
    }
    }

