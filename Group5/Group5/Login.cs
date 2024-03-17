using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group5
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" || textBox2.Text == "")
            {
                MessageBox.Show("Missing Your User Name or Password");
            }else if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                Home obj = new Home();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid User Name or Password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
