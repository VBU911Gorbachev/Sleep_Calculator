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
            ListBox1.Left = (this.ClientSize.Width - ListBox1.Width) / 2;
            ListBox1.Top = (this.ClientSize.Height - ListBox1.Height) / 2;
            ListBox1.Items.Add(0);
            ListBox1.Items.Add(1);
            ListBox1.Items.Add(2);
            ListBox1.Items.Add(3);
            ListBox1.Items.Add(4);
            ListBox1.Items.Add(5);
            ListBox1.Items.Add(6);
            ListBox1.Items.Add(7);
            ListBox1.Items.Add(8);
            ListBox1.Items.Add(9);
            ListBox1.Items.Add(10);
            ListBox1.Items.Add(11);
            ListBox1.Items.Add(12);
            ListBox1.Items.Add(13);
            ListBox1.Items.Add(14);
            ListBox1.Items.Add(15);
            ListBox1.Items.Add(16);
            ListBox1.Items.Add(17);
            ListBox1.Items.Add(18);
            ListBox1.Items.Add(19);
            ListBox1.Items.Add(20);
            ListBox1.Items.Add(21);
            ListBox1.Items.Add(22);
            ListBox1.Items.Add(23);
            //=============================================================
            ListBox2 = new ListBox();
            ListBox2.BackColor = Color.FromArgb(66, 82, 125);
            ListBox2.Left = (this.ClientSize.Width - ListBox2.Width) / 2;
            ListBox2.Top = (this.ClientSize.Height - ListBox2.Height) / 2;
             ListBox2.Items.Add(0);
            ListBox2.Items.Add(1);
            ListBox2.Items.Add(2);
            ListBox2.Items.Add(3);
            ListBox2.Items.Add(4);
            ListBox2.Items.Add(5);
            ListBox2.Items.Add(6);
            ListBox2.Items.Add(7);
            ListBox2.Items.Add(8);
            ListBox2.Items.Add(9);
            ListBox2.Items.Add(10);
            ListBox2.Items.Add(11);
            ListBox2.Items.Add(12);
            ListBox2.Items.Add(13);
            ListBox2.Items.Add(14);
            ListBox2.Items.Add(15);
            ListBox2.Items.Add(16);
            ListBox2.Items.Add(17);
            ListBox2.Items.Add(18);
            ListBox2.Items.Add(19);
            ListBox2.Items.Add(20);
            ListBox2.Items.Add(21);
            ListBox2.Items.Add(22);
            ListBox2.Items.Add(23);
            ListBox2.Items.Add(24);
            ListBox2.Items.Add(25);
            ListBox2.Items.Add(26);
            ListBox2.Items.Add(27);
            ListBox2.Items.Add(28);
            ListBox2.Items.Add(29);
            ListBox2.Items.Add(30);
            ListBox2.Items.Add(31);
            ListBox2.Items.Add(32);
            ListBox2.Items.Add(33);
            ListBox2.Items.Add(34);
            ListBox2.Items.Add(35);
            ListBox2.Items.Add(36);
            ListBox2.Items.Add(37);
            ListBox2.Items.Add(38);
            ListBox2.Items.Add(39);
            ListBox2.Items.Add(40);
            ListBox2.Items.Add(41);
            ListBox2.Items.Add(42);
            ListBox2.Items.Add(43);
            ListBox2.Items.Add(44);
            ListBox2.Items.Add(45);
            ListBox2.Items.Add(46);
            ListBox2.Items.Add(47);
            ListBox2.Items.Add(48);
            ListBox2.Items.Add(49);
            ListBox2.Items.Add(50);
            ListBox2.Items.Add(51);
            ListBox2.Items.Add(52);
            ListBox2.Items.Add(53);
            ListBox2.Items.Add(54);
            ListBox2.Items.Add(55);
            ListBox2.Items.Add(56);
            ListBox2.Items.Add(57);
            ListBox2.Items.Add(58);
            ListBox2.Items.Add(59);
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
