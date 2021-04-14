/* Program:         HW05 - Assignment 11
 * Developed by:    Christopher Karnas
 * Date Created:    October 2020
 * Last Modified:   11.03.20
 * Class Name:      Form1
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CKarnasProgram12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //enable/disable controls upon startup
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
        }

        //declare class level variables. Instantiate object

        Projectile aProjectile;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            //declare method level variables
            int initialHeight, initialVelocity;

            //assgin values
            initialHeight = Convert.ToInt32(nudInitialHeight.Value);
            initialVelocity = Convert.ToInt32(nudInitialVelocity.Value);

            //instantiate object
            aProjectile = new Projectile(initialHeight, initialVelocity);

            //enable/disable controls
            groupBox2.Enabled = true;
            groupBox1.Enabled = false;
        }

        //display max height
        private void btnMaxHeight_Click(object sender, EventArgs e)
        {
            //call the method and convert data type
            lblMaxHeight.Text = "Maximum height reached: " + aProjectile.MaxHeight.ToString("n2") + " feet.";
        }

        //display landing time
        private void btnLandingTime_Click(object sender, EventArgs e)
        {
            //call the method and convert data type
            lblLandingTime.Text = "Time it took to land: " + aProjectile.LandTime.ToString("n2") + " seconds.";
        }

        //reset the form
        private void btnReset_Click(object sender, EventArgs e)
        {
            //reset the inputs/outputs
            nudInitialHeight.Value = nudInitialHeight.Minimum;
            nudInitialVelocity.Value = nudInitialVelocity.Minimum;
            lblMaxHeight.Text = null;
            lblLandingTime.Text = null;

            //enable/disable controls
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
        }

        //exit the form with a prompted warning
        private void btnExit_Click(object sender, EventArgs e)
        {
            // declare variable
            DialogResult aResult;

            // assign the return value to the variable
            aResult = MessageBox.Show("Do you wish to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            // take action based on the value of aResult
            if (aResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                nudInitialHeight.Focus();
            }
        }
    }
}
