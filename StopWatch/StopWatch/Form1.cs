using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        // Variable declaration
        int timeCsec, timeSec, timeMin;
        bool isActive;

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Project stops and time returns = 0
            isActive = false;

            ResetTime();
        }

        private void ResetTime()
        {
            timeCsec = 0;
            timeSec = 0;
            timeMin = 0;
        }

        // Method runs when the project starts
        private void Form1_Load(object sender, EventArgs e)
        {
            // When the project starts, we want all the values = 0
            ResetTime();

            // We have not started the project yet
            isActive = false;
        }
    }
}
