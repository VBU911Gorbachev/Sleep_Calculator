using System;
using System.Windows.Forms;

namespace Sleep_Calculator
{
    public partial class Form1 : Form
    {
        public int sum1 = 0;
        public int sum2 = 0;
        public int sum3 = 0;
        public int sum4 = 0;
        public int res1 = 0;
        public int res2 = 0;
        public int res3 = 0;
        public int res4 = 0;
        public void Sleep_Hours(EventArgs e)
        {
            sum1 = Convert.ToInt32(hours.Text);
            sum2 = Convert.ToInt32(hours.Text);
            sum3 = Convert.ToInt32(hours.Text);
            sum4 = Convert.ToInt32(hours.Text);
            res1 = sum1 - 6;
            res2 = sum2 - 7;
            res3 = sum3 - 8;
            res4 = sum4 - 9;
            result_1.Text = res1.ToString();
            result_2.Text = res2.ToString();
            result_3.Text = res3.ToString();
            result_4.Text = res4.ToString();
        }
    }
}
