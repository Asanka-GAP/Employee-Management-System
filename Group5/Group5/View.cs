using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group5
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=ASANKAPC\SQLEXPRESS;Initial Catalog=EmpDB;Integrated Security=True");
        private void fetchempdata()
        {
            Con.Open();
            string query = "select * from EmpTable where EmpId='"+EmpidTb.Text+"'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt=new DataTable();
            SqlDataAdapter sda= new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Empidlbl.Text = dr["EmpId"].ToString();
                empaddlbl.Text = dr["EmpAdd"].ToString();
                empdoblbl.Text = dr["EmpDOB"].ToString();
                empedulbl.Text = dr["EmpEdu"].ToString();
                empgenderlbl.Text = dr["EmpGen"].ToString();
                empnamelbl.Text = dr["EmpName"].ToString();
                empphonelbl.Text = dr["EmpPhone"].ToString();
                empposlbl.Text = dr["EmpPos"].ToString();
                Empidlbl.Visible = true; 
                empaddlbl.Visible= true;
                empdoblbl.Visible = true;
                empedulbl.Visible = true;
                empgenderlbl.Visible = true;
                empnamelbl.Visible = true;
                empphonelbl.Visible = true;
                empposlbl.Visible = true;
            }
            Con.Close();
        }
        private void View_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home obj=new Home();
            obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()== DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("=====EMPLOYEE SUMMARY=====", new Font("Century Gothic",20,FontStyle.Bold),Brushes.Red,new Point(180));
            e.Graphics.DrawString("* Employee ID:-   "+Empidlbl.Text+ "\n* Employee Name:-   "+empnamelbl.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Black, new Point(10,100));
            e.Graphics.DrawString("* Employee Address:-   " + empaddlbl.Text + "\n* Employee Gender:-   " + empgenderlbl.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Black, new Point(10, 160));
            e.Graphics.DrawString("* Employee Position:-   " + empposlbl.Text + "\n* Employee DOB:-   " + empdoblbl.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Black, new Point(10, 220));
            e.Graphics.DrawString("* Employee Phone NO:-   " + empphonelbl.Text + "\n* Employee Education:-   " + empedulbl.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Black, new Point(10, 280));
        }
    }
}
