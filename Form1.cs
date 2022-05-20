using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salary
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        string Name;
        string designation;
        int salary;
        string gender;
        string opinion;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Name = txtName.Text;
            designation = txtDesignation.Text;
            salary = int.Parse(txtsalary.Text);


            if (radioButton1.Checked)
            {
                gender = "male";
            }
            else
            {
                gender = "female";
            }
            if (chkgood.Checked)
            {
                opinion = "good";

            }
            else
            {
                opinion = "verygood";
            }
            display();
            empty();
            /*lbldisplay.Text = name + "" + designation + "" + salary + "" + gender+""+review;*/
        }
        public void display()
        {
            dt.Columns.Add("Name");
            dt.Columns.Add("designation");
            dt.Columns.Add("salary");
            dt.Columns.Add("gender");
            dt.Columns.Add("opinion");
            DataRow dr = dt.NewRow();
            dr[0] = Name;
            dr[1] = designation;
            dr[2] = salary;
            dr[3] = gender;
            dr[4] = opinion;
            dt.Rows.Add(dr);
            dtDataGridView.DataSource = dt;

        }
        public void empty()
       {
            txtName.Text = "";
            txtDesignation.Text= "";
            txtsalary.Text ="";
            }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
