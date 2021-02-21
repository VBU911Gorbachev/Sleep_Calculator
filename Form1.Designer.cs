using System.Windows.Forms;
using System.Drawing;
namespace Sleep_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            ListBox1 = new ListBox();
            ListBox1.BackColor = Color.FromArgb(66, 82, 125);
            ListBox1.Items.Add(ListBox1);
            ListBox1.Left = (this.ClientSize.Width - ListBox1.Width) / 2;
            ListBox1.Top = (this.ClientSize.Height - ListBox1.Height) / 2;
            ListBox2 = new ListBox();
            ListBox2.BackColor = Color.FromArgb(66, 82, 125);
            ListBox2.Items.Add(ListBox2);
            ListBox2.Left = (this.ClientSize.Width - ListBox2.Width) / 2;
            ListBox2.Top = (this.ClientSize.Height - ListBox2.Height) / 2;
            btn1 = new Button();
            btn1.Left = (this.ClientSize.Width - btn1.Width) / 2;
            btn1.Top = (this.ClientSize.Height - btn1.Height) / 2;
            btn1.BackColor = Color.FromArgb(93, 115, 176);
            btn1.Text = "Рассчитать";
            label1 = new Label();
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = (this.ClientSize.Height - label1.Height) / 2;
            label1.Text = "Время сна";
            label1.ForeColor = Color.White;
            Label2 = new Label();
            Label2.Left = (this.ClientSize.Width - Label2.Width) / 2;
            Label2.Top = (this.ClientSize.Height - Label2.Height) / 2;
            Label2.Text = "Хочу проснуться в . . .";
            Label2.ForeColor = Color.White;
        }
        ListBox ListBox1;
        ListBox ListBox2;
        Button btn1;
        Label label1;
        Label Label2;
        #endregion
    }
}

