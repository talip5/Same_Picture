using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Same_Picture
{
    public partial class Form1 : Form
    {
        public int screen_width;
        public int screen_height;
        public Form1()
        {
            InitializeComponent();
            this.Load+=Form1_Load;

            button1.MouseDown+=Button1_MouseDown;
            button1.Click+=Button1_Click;

            button2.Click+=Button2_Click;
            button2.Enabled=true;
           

            //string[] strings1 = { "picture1", "picture2", "picture3", "picture4" };
            //screen_width = this.Width;
            screen_width = Screen.PrimaryScreen.Bounds.Width;
            screen_height = Screen.PrimaryScreen.Bounds.Height;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text ="button1";
            label2.Text ="button2";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(200,200);
            this.Width = screen_width-300;
            this.Height = screen_height-300;
            //this.BackColor = SystemColors.Window;
            //this.BackColor = SystemColors.GrayText;
            this.BackColor = Color.ForestGreen;
            this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
             


            //string[] strings1 = new string[] { "a1", "a2" };
            string[] strings1 = new string[4];
            strings1 = new string[] { "picture1", "picture2", "picture3", "picture4" };

            //label1.Text = strings1[0];
            //label1.Text = screen_width.ToString();
            //label2.Text = screen_height.ToString();
            
            //label1.Text = string.Empty;
            //label2.Text = string.Empty;
            label1.BackColor = Color.Orange;
            label2.BackColor = Color.Orange;
            label1.AutoSize = false;
            label2.AutoSize = false;
            label1.Location = new Point(10,10);
            label2.Location = new Point(10,100);
            label1.Width = 100;
            label2.Width = 100;
            label1.Height = 50;
            label2.Height = 50;
            
            button1.Location = new Point(this.Width - 100,10);
            button1.Text = "Form Close";
            //button1.Text = button2.Visible.ToString();

            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = new Point(50,50);
            form2.Width = screen_width - 100;
            form2.Height = screen_height - 100;
            //form2.WindowState = FormWindowState.Maximized;
            //form2.BackColor = this.BackColor;
            form2.BackColor =SystemColors.Desktop;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.Show();

        }
    }
}
