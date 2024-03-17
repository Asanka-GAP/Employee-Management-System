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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Employee obj1 = new Employee();
            obj1.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Employee obj2 = new Employee();
            obj2.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login obj3 = new Login();
            obj3.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login obj4 = new Login();
            obj4.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            View obj5 = new View();
            obj5.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            View obj6 = new View();
            obj6.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Salary obj = new Salary();
            obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Salary obj = new Salary();
            obj.Show();
            this.Hide();
        }
    }
}
