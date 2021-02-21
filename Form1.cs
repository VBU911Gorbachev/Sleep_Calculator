using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            ListBox1 = new ListBox();
            ListBox1.BackColor = Color.FromArgb(66, 82, 125);
            ListBox1.Items.Add(ListBox1);
            ListBox1.Left = (this.ClientSize.Width - ListBox1.Width) / 2;
            ListBox1.Top = (this.ClientSize.Height - ListBox1.Height) / 2;
            //=============================================================
            ListBox2 = new ListBox();
            ListBox2.BackColor = Color.FromArgb(66, 82, 125);
            ListBox2.Items.Add(ListBox2);
            ListBox2.Left = (this.ClientSize.Width - ListBox2.Width) / 2;
            ListBox2.Top = (this.ClientSize.Height - ListBox2.Height) / 2;
            //=============================================================
            btn1 = new Button();
            btn1.Left = (this.ClientSize.Width - btn1.Width) / 2;
            btn1.Top = (this.ClientSize.Height - btn1.Height) / 2;
            btn1.BackColor = Color.FromArgb(93, 115, 176);
            btn1.Text = "Рассчитать";
            //=============================================================
            label1 = new Label();
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = (this.ClientSize.Height - label1.Height) / 2;
            label1.Text = "Время сна";
            label1.ForeColor = Color.White;
            //=============================================================
            Label2 = new Label();
            Label2.Left = (this.ClientSize.Width - Label2.Width) / 2;
            Label2.Top = (this.ClientSize.Height - Label2.Height) / 2;
            Label2.Text = "Хочу проснуться в . . .";
            Label2.ForeColor = Color.White;
            //=============================================================
        }
        ListBox ListBox1;
        ListBox ListBox2;
        Button btn1;
        Label label1;
        Label Label2;
    }
}
