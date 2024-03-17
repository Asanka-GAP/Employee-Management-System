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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
SqlConnection Con=new SqlConnection(@"Data Source=ASANKAPC\SQLEXPRESS;Initial Catalog=EmpDB;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            if (EmpIdTb.Text == "" || EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || EmpAddTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into EmpTable values('" + EmpIdTb.Text + "','" + EmpNameTb.Text + "','" + EmpAddTb.Text + "','"+EmpPosCb.SelectedItem.ToString()+"','"+Empdob.Value.Date+"','"+EmpPhoneTb.Text+"','"+EmpEduCb.SelectedItem.ToString()+"','"+EmpGenCb.SelectedItem.ToString()+"')";
                    SqlCommand cmd=new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Added");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from EmpTable";
            SqlDataAdapter sda=new SqlDataAdapter(query,Con);
            SqlCommandBuilder builder=new SqlCommandBuilder(sda);
            var ds=new DataSet();
            sda.Fill(ds);
            EmpDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Employee_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (EmpIdTb.Text == "")
            {
                MessageBox.Show("Enter the Employee ID");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from EmpTable where EmpId='"+EmpIdTb.Text+"'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted Successfully");
                    EmpIdTb.Text = "";
                    Con.Close();
                    populate();
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EmpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpIdTb.Text = EmpDGV.SelectedRows[0].Cells[0].Value.ToString();
            EmpNameTb.Text = EmpDGV.SelectedRows[0].Cells[1].Value.ToString();
            EmpAddTb.Text = EmpDGV.SelectedRows[0].Cells[2].Value.ToString();
            EmpEduCb.Text = EmpDGV.SelectedRows[0].Cells[6].Value.ToString();
            EmpPosCb.Text = EmpDGV.SelectedRows[0].Cells[3].Value.ToString();
            EmpPhoneTb.Text = EmpDGV.SelectedRows[0].Cells[5].Value.ToString();
            EmpGenCb.Text = EmpDGV.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (EmpIdTb.Text == "" || EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || EmpAddTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update EmpTable set EmpName='"+EmpNameTb.Text+"',EmpAdd='"+EmpAddTb.Text+"',EmpPos='"+EmpPosCb.SelectedItem.ToString()+"',EmpDOB='"+Empdob.Value.Date+"',EmpPhone='"+EmpPhoneTb.Text+"',EmpEdu='"+EmpEduCb.SelectedItem.ToString()+"',EmpGen='"+EmpGenCb.SelectedItem.ToString()+"' where EmpId='"+EmpIdTb.Text+"';";
                    SqlCommand cmd=new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Update Successfully");
                    Con.Close();
                    populate();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home obj=new Home();
            obj.Show();
            this.Hide();
        }
    }
}
