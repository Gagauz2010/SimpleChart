﻿using System.Drawing;
using System.Windows.Forms;

namespace SimpleChart
{
    public partial class Form1 : Form
    {
        //Chart chart;

        public Form1()
        {
            InitializeComponent();

            //chart = new Chart(panel1, myFunc, step: 10, OXbegin: 50, OYbegin: 50);
        }

        double myFunc(double x)
        {
            return 3 * x + 5;
        }

        private void scaleBar_Scroll(object sender, System.EventArgs e)
        {
            labelScaleValue.Text = (scaleBar.Value * 25).ToString() + "%";
        }

        private void scaleBar_ValueChanged(object sender, System.EventArgs e)
        {
            labelScaleValue.Text = (scaleBar.Value * 25).ToString() + "%";
        }

        private void buttonResetScale_Click(object sender, System.EventArgs e)
        {
            scaleBar.Value = 4;
        }


    }
}