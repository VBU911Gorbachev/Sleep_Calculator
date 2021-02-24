using System;
using System.Windows.Forms;

namespace Sleep_Calculator
{
    public partial class Form1 : Form
    {
        public int sum_hour_1 = 0, sum_min_1 = 0;
        public int sum_hour_2 = 0, sum_min_2 = 0;
        public int sum_hour_3 = 0, sum_min_3 = 0;
        public int sum_hour_4 = 0, sum_min_4 = 0;
        public int res1 = 0;
        public int res2 = 0, minus_res2 = 0;
        public int res3 = 0;
        public int res4 = 0, minus_res4 = 0;
        public void Sleep_Hours(EventArgs e)
        {
            //=============================================================
            sum_hour_1 = Convert.ToInt32(hours.Text);
            sum_min_1 = Convert.ToInt32(minutes.Text);
            sum_hour_2 = Convert.ToInt32(hours.Text);
            sum_min_2 = Convert.ToInt32(minutes.Text);
            sum_hour_3 = Convert.ToInt32(hours.Text);
            sum_min_3 = Convert.ToInt32(minutes.Text);
            sum_hour_4 = Convert.ToInt32(hours.Text);
            sum_min_4 = Convert.ToInt32(minutes.Text);
            //=============================================================
            res1 = sum_hour_1 - 6;
            res2 = sum_hour_2 - 7;
            res3 = sum_hour_3 - 9;
            res4 = sum_hour_4 - 10;
            if (sum_min_1 == 0 && sum_hour_1 == 0 && sum_hour_2 == 0 && sum_min_2 == 0 && sum_hour_3 == 0 && sum_min_3 == 0 && sum_hour_4 == 0 && sum_min_4 == 0)
            {
                res1 = 24 - 6;
                res2 = 24 - 7;
                res3 = 24 - 9;
                res4 = 24 - 10;
            }
            //=============================================================
            if (sum_hour_1 < 6 && sum_hour_2 < 6 && sum_hour_3 < 6 && sum_hour_4 < 6)
            {
                res1 = (24 + sum_hour_1) - 6;
                res2 = (24 + sum_hour_2) - 7;
                res3 = (24 + sum_hour_3) - 9;
                res4 = (24 + sum_hour_4) - 10;
            }
            //=============================================================
            if (res1 < 0 || res2 < 0 || res3 < 0 || res4 < 0)
            {
                res1 = 24 - (6 - sum_hour_1);
                res2 = 24 - (7 - sum_hour_2);
                res3 = 24 - (9 - sum_hour_3);
                res4 = 24 - (10 - sum_hour_4);
            }
            //=============================================================
            if (sum_hour_1 == 6)
            {
                res1 = 0;
            }
            if (sum_hour_1 == 7)
            {
                res1 = 1;
                res2 = 0;
            }
            if (sum_hour_1 == 8)
            {
                res1 = 2;
                res2 = 1;
            }
            if (sum_hour_1 == 9)
            {
                res1 = 3;
                res2 = 2;
                res3 = 0;
            }
            //=============================================================
            sum_min_2 += 30;
            sum_min_4 += 30;
            //=============================================================
            // res1
            result_1.Text = res1.ToString() + ":" + sum_min_1.ToString();
            if (sum_min_1 < 10 || sum_min_1 == 0)
            {
                result_1.Text = res1.ToString() + ": 0" + sum_min_1.ToString();
            }
            //=============================================================
            // res2
            if (sum_min_2 > 59)
            {
                sum_hour_2++;
                sum_min_2 = 60 - sum_min_2;
            }
            result_2.Text = res2.ToString() + ":" + sum_min_2.ToString();
            if (sum_min_2 < 10 || sum_min_2 == 0)
            {
                result_2.Text = res2.ToString() + ": 0" + sum_min_2.ToString();
            }
            if (sum_min_2 < 0)
            {
                minus_res2 = sum_min_2 * -1;
                result_2.Text = res1.ToString() + ":" + minus_res2.ToString();
            }
            //=============================================================
            // res3
            result_3.Text = res3.ToString() + ":" + sum_min_3.ToString();
            if (sum_min_3 < 10 || sum_min_3 == 0)
            {
                result_3.Text = res3.ToString() + ": 0" + sum_min_3.ToString();
            }
            //=============================================================
            // res4
            if (sum_min_4 > 59)
            {
                sum_hour_4++;
                sum_min_4 = 60 - sum_min_4;
            }
            result_4.Text = res4.ToString() + ":" + sum_min_4.ToString();
            if (sum_min_4 < 10 || sum_min_4 == 0)
            {
                result_4.Text = res4.ToString() + ": 0" + sum_min_4.ToString();
            }
            if (sum_min_4 < 0)
            {
                minus_res4 = sum_min_4 * -1;
                result_4.Text = res1.ToString() + ":" + minus_res4.ToString();
            }
            //=============================================================
        }
    }
}
