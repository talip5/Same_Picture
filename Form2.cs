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
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
            button1.BackColor =Color.Orange;
            button1.Text = this.Width.ToString(); // 816 pixel

            this.Load +=Form2_Load;
            button1.Click+=Button1_Click;
            button2.Click+=Button2_Click;
            button3.Click+=Button3_Click;

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.TopLevel = false;
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //button1.Text = this.Width.ToString(); // 1804 pixel
            button1.Text ="Close";

            button1.Left = this.Width - 150;
            button1.Top = 10;

            button2.Left = this.Width - 150;
            button2.Top = 50;
            button2.Text ="Front";

            button3.Left = this.Width - 150;
            button3.Top = 100;
            button3.Text ="Back";

            
            

         

        }
    }
}
