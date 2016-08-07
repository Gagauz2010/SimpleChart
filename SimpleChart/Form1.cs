using System.Windows.Forms;

namespace SimpleChart
{
    public partial class Form1 : Form
    {
        Chart chart;

        public Form1()
        {
            InitializeComponent();

            chart = new Chart(panel1, myFunc, step: 10, OXbegin: 50, OYbegin: 50);
        }

        float myFunc(float x)
        {
            return x * x;
        }

        private void scaleBar_Scroll(object sender, System.EventArgs e)
        {
            labelScaleValue.Text = (scaleBar.Value * 25).ToString() + "%";
            chart.zoomInOut(scaleBar.Value);
        }

        private void scaleBar_ValueChanged(object sender, System.EventArgs e)
        {
            labelScaleValue.Text = (scaleBar.Value * 25).ToString() + "%";
            chart.zoomInOut(scaleBar.Value);
        }

        private void buttonResetScale_Click(object sender, System.EventArgs e)
        {
            scaleBar.Value = 4;
        }

        private void buttonLeft_Click(object sender, System.EventArgs e)
        {
            chart.leftShift();
        }

        private void buttonUp_Click(object sender, System.EventArgs e)
        {
            chart.upShift();
        }

        private void buttonRight_Click(object sender, System.EventArgs e)
        {
            chart.rightShift();
        }

        private void buttonDown_Click(object sender, System.EventArgs e)
        {
            chart.downShift();
        }

        private void panel1_SizeChanged(object sender, System.EventArgs e)
        {
            panel1.Refresh();
        }
    }
}
