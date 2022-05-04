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
    public partial class customermanagement : Form
    {
        public customermanagement()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateandtime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {

           

            if (txtfname.Text.All(char.IsLetter) &&  txtphoneno.Text.All(char.IsDigit) && txtphoneno.Text.Length == 10 && txtlno.Text.All(char.IsDigit) && txtnicno.Text.All(char.IsDigit) && txtaddress.Text.All(char.IsLetter) && txtcus.Text.All(char.IsDigit) && txtfname.Text != " " &&  txtcus.Text != " " && txtaddress.Text != " " && txtlno.Text != " " && txtnicno.Text != " " && txtphoneno.Text != " ")
            {

                string b = dateandtime.Value.ToString();
                int p = Convert.ToInt32(txtphoneno.Text);

                    

                    SqlConnection con2 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                    SqlCommand cmd = new SqlCommand("insert into customerManagement(CusID,Name,PhoneNo,licenceNo,Address,DateOfBirth,NicNo) values('" + txtcus.Text + "','" + txtfname.Text + "','" + p + "','" + txtlno.Text + "','" + txtaddress.Text + "','" + b + "','" + txtnicno.Text + "')", con2);


                    try
                    {

                        con2.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("insert");
                        con2.Close();

                        SqlDataAdapter adt = new SqlDataAdapter("select * from customerManagement", con2);
                        DataTable dt = new DataTable();
                        adt.Fill(dt);


                        dgv2.DataSource = dt;
                        txtfname.Text = "";
                        
                        txtphoneno.Text = "";
                        txtaddress.Text = "";
                        txtlno.Text = "";
                        txtnicno.Text = "";
                        txtcus.Text = "";
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                
            }

            
            
            else
            {

                MessageBox.Show("you have mistake please try again");

                txtfname.Text = "";
                
                txtphoneno.Text = "";
                txtaddress.Text = "";
                txtlno.Text = "";
                txtnicno.Text = "";
                txtcus.Text = "";

            }

            
            
        }

        private void btndis_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con2 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

                SqlDataAdapter adt = new SqlDataAdapter("select * from customerManagement", con2);
                DataTable dt = new DataTable();
                adt.Fill(dt);

                dgv2.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if(txtdel.Text.All(char.IsDigit)&& txtdel.Text!="")
            {
            SqlConnection con2 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlCommand cmd = new SqlCommand("delete from customerManagement where CusID = '" + txtdel.Text + "'", con2);
            try
            {
                con2.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("deleted completed");
                con2.Close();


                SqlDataAdapter adt = new SqlDataAdapter("select * from customerManagement", con2);
                DataTable dt = new DataTable();
                adt.Fill(dt);

                dgv2.DataSource = dt;

                txtdel.Text = "";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            }

            else if (txtdel.Text == "")
            {
                MessageBox.Show("delete box is empty please enter the customer number");
            }
            else
            {

                MessageBox.Show("cannot use letter for delete box please enter customer number");
            }
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            if (txtfname.Text.All(char.IsLetter) &&  txtphoneno.Text.All(char.IsDigit) && txtphoneno.Text.Length == 10 && txtlno.Text.All(char.IsDigit) && txtnicno.Text.All(char.IsDigit) && txtaddress.Text.All(char.IsLetter) && txtcus.Text.All(char.IsDigit))
            {
                string x = dateandtime.Value.ToString();
                int p1 = Convert.ToInt32(txtphoneno.Text);
                SqlConnection con2 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

                SqlCommand cmd = new SqlCommand("update customerManagement set CusID= '" + txtcus.Text + "', FirstName='" + txtfname.Text + "', PhoneNO='" + p1 + "',licenceNo='" + txtlno.Text + "',Address='" + txtaddress.Text + "',DateOfBirth='" + x + "',NicNo='" + txtnicno.Text + "' where CusID='" + txtcus.Text + "'", con2);

                try
                {

                    con2.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("update completed");
                    con2.Close();


                    SqlDataAdapter adt = new SqlDataAdapter("select * from customerManagement", con2);
                    DataTable dt = new DataTable();
                    adt.Fill(dt);

                    dgv2.DataSource = dt;

                    txtfname.Text = "";
                    
                    txtphoneno.Text = "";
                    txtaddress.Text = "";
                    txtlno.Text = "";
                    txtnicno.Text = "";
                    txtcus.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else
            {
                MessageBox.Show("you have mistake please try again");
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text.All(char.IsDigit) && txtsearch.Text != "")
            {
                try
                {
                    SqlConnection con2 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                    SqlDataAdapter adt = new SqlDataAdapter("select * from customerManagement where CusID ='" + txtsearch.Text + "' ", con2);
                    DataTable dt = new DataTable();

                    adt.Fill(dt);

                    dgv2.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txtsearch.Text = "";
            }
            else if (txtsearch.Text == "")
            {
                MessageBox.Show("search box is empty please enter custermer number for search");
            }

            else
            {
                MessageBox.Show("cannot use letter for search box please enter the customer number");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            new home().Show();
            this.Hide();
        }

        
    }
}
