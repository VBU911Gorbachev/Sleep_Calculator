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
            description.Location = new Point(20, 300);
            description.Width = 500;
            description.Font = new Font("Gill Sans Ultra Bold", 14);
            description.Text = "Хочу проснуться в . . .";
            description.ForeColor = Color.White;
            Controls.Add(description);
            //=============================================================
            double_dotes = new Label();
            double_dotes.Location = new Point(3, 300);
            double_dotes.Size = new Size(50, 50);
            double_dotes.Font = new Font("Gill Sans Ultra Bold", 10);
            double_dotes.Text = ":";
            double_dotes.ForeColor = Color.White;
            Controls.Add(double_dotes);
            //=============================================================
            authors = new Label();
            authors.Location = new Point(200, 100);
            authors.Text = "Горбачёв Кирилл & Куваев Никита";
            authors.ForeColor = Color.White;
            Controls.Add(authors);
            //=============================================================
        }
        ComboBox hours;
        ComboBox minutes;
        Button calc_btn;
        Label prog_name;
        Label description;
        Label double_dotes;
        Label authors;
    }
}
