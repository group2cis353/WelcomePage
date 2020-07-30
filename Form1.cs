using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Welcome_Page
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //opens search window
        private void conductSearchBtn_Click(object sender, EventArgs e)
        {

        }
        //opens window to start entering a new assessment
        private void startAssessmentBtn_Click(object sender, EventArgs e)
        {

        }
        //double checks and ends program
        private void endProgramBtn_Click(object sender, EventArgs e)
        {
            string leave = "Are you sure you want to quit?";
            string title = "Leaving";
            DialogResult answer = MessageBox.Show(leave, title, MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                //program continues
            }
        }
    }
}
