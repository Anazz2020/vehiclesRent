using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace rent
{
    public partial class vehicle_category : Form
    {
        public vehicle_category()
        {
            InitializeComponent();
        }

        private void btnins_Click(object sender, EventArgs e)
        {




            if (txtname.Text.All(char.IsLetter) && txtdis.Text.All(char.IsLetterOrDigit) && txtcid.Text.All(char.IsDigit) && txtname.Text != "" && txtcid.Text != "" && txtdis.Text != "")
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                SqlCommand cmd = new SqlCommand("insert into vehiclecategory(cid,name,discription) values('" + txtcid.Text + "','" + txtname.Text + "','" + txtdis.Text + "')", con);




                con.Open();


                cmd.ExecuteNonQuery();
                MessageBox.Show("insert");
                con.Close();
                SqlDataAdapter adt = new SqlDataAdapter("select*from vehiclecategory", con);
                DataTable dt = new DataTable();

                adt.Fill(dt);
                dgv1.DataSource = dt;

                txtname.Text = "";

                txtdis.Text = "";
                txtcid.Text = "";
            }
            else
            {

                MessageBox.Show("you have mistakes please try again");
            }

           

        }

        private void btndis_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlDataAdapter cmd = new SqlDataAdapter("select * from vehiclecategory",con1);
            DataTable dt = new DataTable();

            cmd.Fill(dt);

            dgv1.DataSource = dt;

        }

        private void btnup_Click(object sender, EventArgs e)
        {
            if (txtname.Text.All(char.IsLetter) && txtdis.Text.All(char.IsLetterOrDigit) && txtcid.Text.All(char.IsDigit) && txtname.Text != "" && txtcid.Text != "" && txtdis.Text != "")
            {
                SqlConnection con1 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                SqlCommand cmd = new SqlCommand("update vehiclecategory set name= '" + txtname.Text + "',cid='" + txtcid.Text + "',discription='" + txtdis.Text + "' where cid='" + txtcid.Text + "'", con1);
                SqlDataAdapter adt = new SqlDataAdapter("select * from vehiclecategory", con1);
                DataTable dt = new DataTable();

                adt.Fill(dt);
                con1.Open();
                cmd.ExecuteNonQuery();
                con1.Close();
                dgv1.DataSource = dt;

                txtname.Text = "";

                txtdis.Text = "";
                txtcid.Text = "";
            }


            
            else
            {
                MessageBox.Show("you have mistakes please try again");
            }

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (txtdel.Text.All(char.IsLetter) && txtdel.Text!="")
            {
                SqlConnection con1 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                SqlCommand cmd = new SqlCommand("delete  from vehiclecategory where name='" +txtdel.Text+ "'", con1);




                con1.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("deleted");
                con1.Close();
                SqlDataAdapter adt = new SqlDataAdapter("select *from vehiclecategory ", con1);
                DataTable dt = new DataTable();
                adt.Fill(dt);


                dgv1.DataSource = dt;

                txtdel.Text = "";
            }
            else if (txtdel.Text == "")
            {

                MessageBox.Show("delete textbox is empty please enter category name ");
            }

            else
            {


                MessageBox.Show("cannot use numbers for delete, pls enter category name ");

            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtser.Text.All(char.IsLetter)&&txtser.Text!="")
            {
                SqlConnection con1 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                SqlCommand cmd = new SqlCommand("select * from vehiclecategory where name= '" + txtser.Text + "'", con1);

                con1.Open();
                cmd.ExecuteReader();

                con1.Close();
                SqlDataAdapter adt = new SqlDataAdapter("select *from vehiclecategory where name= '" + txtser.Text + "' ", con1);
                DataTable dt = new DataTable();
                adt.Fill(dt);


                dgv1.DataSource = dt;
                txtser.Text = "";
            }
            else if (txtser.Text == "")
            {
                MessageBox.Show("search box is empty please enter the category name for search");
            }


            else
            {
                MessageBox.Show("cannot use numbers for search pls enter category name");
            }
        }
    }
}
