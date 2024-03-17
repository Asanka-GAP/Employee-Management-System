using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Group5
{
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=ASANKAPC\SQLEXPRESS;Initial Catalog=EmpDB;Integrated Security=True");

        private void Salary_Load(object sender, EventArgs e)
        {

        }
        private void fetchempdata()
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Enter Employee Id");
            }
            else
            {
                Con.Open();
                string query = "select * from EmpTable where EmpId='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {

                    textBox2.Text = dr["EmpName"].ToString();
                    textBox3.Text = dr["EmpPos"].ToString();

                }
                Con.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }
        int Dailybase,total;

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("=====SALARY DOCUMENT=====", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(180));
            e.Graphics.DrawString("* Employee ID:-   " + textBox1.Text , new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Black, new Point(10, 100));
            e.Graphics.DrawString("* Employee Name:-   " + textBox2.Text , new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Black, new Point(10, 160));
            e.Graphics.DrawString("* Employee Position:-   " + textBox3.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Black, new Point(10, 220));
            e.Graphics.DrawString("* Worked Days:-   " + textBox4.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Black, new Point(10, 280));
            e.Graphics.DrawString("* Daily Pay:-   Rs." + Dailybase, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Black, new Point(10, 400));
            e.Graphics.DrawString("* Total Salary:-   Rs." +total, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Black, new Point(10, 460));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Select an Employee");
            } else if (textBox4.Text=="" || Convert.ToInt32(textBox4.Text)>28) {
                MessageBox.Show("Enter a valid number of Days..");
            }
            else
            {
                if (textBox3.Text == "Manager")
                {
                    Dailybase = 1200;
                }else if(textBox3.Text=="Senior Developper")
                {
                    Dailybase = 1000;
                }else if (textBox3.Text=="Junior Developper")
                {
                    Dailybase = 950;
                }
                else
                {
                    Dailybase = 850;
                }
                total=Dailybase*Convert.ToInt32(textBox4.Text);
                richTextBox1.Text ="Employee ID:- "+ textBox1.Text + "\n" +"Employee Name:- "+ textBox2.Text + "\n" +"Employee Position:- "+ textBox3.Text + "\n" + "Days Worked:- "+textBox4.Text + "\n" +"Daily Salary  Rs."+Dailybase+ "\n"+"Total Amount  Rs."+total;
            }
        }
    }
}
