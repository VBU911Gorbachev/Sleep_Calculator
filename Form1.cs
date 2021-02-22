using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sleep_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //=============================================================
            hours = new ComboBox();
            hours.BackColor = Color.FromArgb(23, 43, 99);
            hours.Width = 80;
            hours.Location = new Point(305, 300);
            hours.ForeColor = Color.White;
            for (int i = 0; i < 24; i++)
            {
                hours.Items.Add(i);
            }
            Controls.Add(hours);
            //=============================================================
            minutes = new ComboBox();
            minutes.BackColor = Color.FromArgb(23, 43, 99);
            minutes.Width = 80;
            minutes.Location = new Point(485, 300);
            minutes.ForeColor = Color.White;
            for (int i = 0; i < 60; i++)
            {
                minutes.Items.Add(i);
            }
            Controls.Add(minutes);
            //=============================================================
            calc_btn = new Button();
            calc_btn.Click += Calc_btn_Click; 
            calc_btn.Location = new Point(385, 400);
            calc_btn.Size = new Size(100, 50);
            calc_btn.BackColor = Color.FromArgb(58, 110, 252);
            calc_btn.ForeColor = Color.White;
            calc_btn.FlatStyle = FlatStyle.Flat;
            calc_btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            calc_btn.Font = new Font("Gill Sans Ultra Bold", 10);
            calc_btn.Text = "Рассчитать";
            Controls.Add(calc_btn);
            //=============================================================
            prog_name = new Label();
            prog_name.Location = new Point(340, 200);
            prog_name.Size = new Size(200, 100);
            prog_name.Text = "КАЛЬКУЛЯТОР СНА";
            prog_name.Font = new Font("Gill Sans Ultra Bold", 14);
            prog_name.ForeColor = Color.White;
            Controls.Add(prog_name);
            //=============================================================
            description = new Label();
            description.Location = new Point(40, 300);
            description.Width = 250;
            description.Font = new Font("Gill Sans Ultra Bold", 14);
            description.Text = "Хочу проснуться в . . .";
            description.ForeColor = Color.White;
            Controls.Add(description);
            //=============================================================
            double_dotes = new Label();
            double_dotes.Location = new Point(425, 300);
            double_dotes.Size = new Size(50, 50);
            double_dotes.Font = new Font("Gill Sans Ultra Bold", 10);
            double_dotes.Text = ":";
            double_dotes.ForeColor = Color.White;
            Controls.Add(double_dotes);
            //=============================================================
            authors = new Label();
            authors.Location = new Point(310, 600);
            authors.Width = 300;
            authors.Font = new Font("Gill Sans Ultra Bold", 10);
            authors.Text = "(c) Горбачёв Кирилл, Куваев Никита";
            authors.ForeColor = Color.White;
            Controls.Add(authors);
            //=============================================================
            result_1 = new Label();
            result_1.BorderStyle = BorderStyle.Fixed3D;
            result_1.Location = new Point(205, 525);
            result_1.Size = new Size(100, 20);
            result_1.BackColor = Color.FromArgb(23, 43, 99);
            Controls.Add(result_1);
            //=============================================================
            result_2 = new Label();
            result_2.BorderStyle = BorderStyle.Fixed3D;
            result_2.Location = new Point(325, 525);
            result_2.Size = new Size(100, 20);
            result_2.BackColor = Color.FromArgb(23, 43, 99);
            Controls.Add(result_2);
            //=============================================================
            result_3 = new Label();
            result_3.BorderStyle = BorderStyle.Fixed3D;
            result_3.Location = new Point(445, 525);
            result_3.Size = new Size(100, 20);
            result_3.BackColor = Color.FromArgb(23, 43, 99);
            Controls.Add(result_3);
            //=============================================================
            result_4 = new Label();
            result_4.BorderStyle = BorderStyle.Fixed3D;
            result_4.Location = new Point(565, 525);
            result_4.Size = new Size(100, 20);
            result_4.BackColor = Color.FromArgb(23, 43, 99);
            Controls.Add(result_4);
            //=============================================================
            res_name = new Label();
            res_name.Location = new Point(365, 495);
            res_name.Width = 150;
            res_name.Text = "Вам лучше лечь в:";
            res_name.Font = new Font("Gill Sans Ultra Bold", 10);
            Controls.Add(res_name);
            //=============================================================
        }

        private void Calc_btn_Click(object sender, EventArgs e)
        {
            Sleep_Hours(e);
        }

        ComboBox hours;
        ComboBox minutes;
        Label result_1;
        Label result_2;
        Label result_3;
        Label result_4;
        Button calc_btn;
        Label prog_name;
        Label description;
        Label double_dotes;
        Label authors;
        Label res_name;
    }
}
