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
    public partial class CarManagement : Form
    {
        public CarManagement()
        {
            InitializeComponent();
            fillcombo();
        }

        void fillcombo()
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            
            SqlDataAdapter adt = new SqlDataAdapter("select name from vehiclecategory",con);
            DataTable dt = new DataTable();

            adt.Fill(dt);

            cmbcategory.DataSource = dt;
            cmbcategory.DisplayMember = "name";
        }

        private void CarManagement_Load(object sender, EventArgs e)
        {
            pnlside.Visible = false;
        }

        private void btndeleteandsearchside_Click(object sender, EventArgs e)
        {
            pnlside.Visible = true;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            pnlside.Visible = false;
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if (txtcarid.Text.All(char.IsDigit) && txtcarname.Text.All(char.IsLetter) && txtcolor.Text.All(char.IsLetter) && txtdeilyprice.Text.All(char.IsDigit) && txtinsurance.Text.All(char.IsDigit) && txtregno.Text.All(char.IsDigit) && txtregno.Text != "" && txtinsurance.Text != "" && txtdeilyprice.Text != "" && txtcolor.Text != "" && txtcarname.Text != "" && txtcarid.Text != "")
            {



                string mdf = datetimemfd.Value.ToString();
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                SqlCommand cmd = new SqlCommand("insert into CarManagement(CarID,CarName,Category,Color,MfdDate,InsuranceNo,RegNo,DailyPrice) values ('" + txtcarid.Text + "','" + txtcarname.Text + "','" + cmbcategory.Text + "','" + txtcolor.Text + "','" + mdf + "','" + txtinsurance.Text + "','" + txtregno.Text + "','" + txtdeilyprice.Text + "') ", con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("insert");
                    con.Close();

                    SqlDataAdapter adt = new SqlDataAdapter("select * from CarManagement", con);
                    DataTable dt = new DataTable();

                    adt.Fill(dt);

                    dgv4.DataSource = dt;

                    txtregno.Text = "";
                    txtinsurance.Text = "";
                    txtdeilyprice.Text = "";
                    txtcolor.Text = "";
                    txtcarname.Text = "";
                    txtcarid.Text = "";



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else if (txtcarid.Text == "")
            {
                MessageBox.Show("CAR ID box is empty please enter the CAR ID");
            }
            else if (txtcarname.Text == "")
            {
                MessageBox.Show("CAR NAMe box is empty please enter the CAR NAME");
            }
            else if (txtcolor.Text == "")
            {
                MessageBox.Show("color box is empty please enter the color");
            }
            else if (txtdeilyprice.Text == "")
            {
                MessageBox.Show("DEILY PRICE box is empty please enter the Deily Price");
            }
            else if (txtinsurance.Text == "")
            {
                MessageBox.Show("INSURANCE NO box is empty please enter the INSURANCE NO ");
            }
            else if (txtregno.Text == "")
            {
                MessageBox.Show("REG NO is empty please enter the REG NO");
            }

            else
            {
                MessageBox.Show("you have mistakes please try again");

                txtregno.Text = "";
                txtinsurance.Text = "";
                txtdeilyprice.Text = "";
                txtcolor.Text = "";
                txtcarname.Text = "";
                txtcarid.Text = "";
            }

            
            
            
           
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

                SqlDataAdapter adt = new SqlDataAdapter("select * from CarManagement", con);
                DataTable dt = new DataTable();

                adt.Fill(dt);

                dgv4.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtcarid.Text.All(char.IsDigit) && txtcarname.Text.All(char.IsLetter) && txtcolor.Text.All(char.IsLetter) && txtdeilyprice.Text.All(char.IsDigit) && txtinsurance.Text.All(char.IsDigit) && txtregno.Text.All(char.IsDigit) && txtregno.Text != "" && txtinsurance.Text != "" && txtdeilyprice.Text != "" && txtcolor.Text != "" && txtcarname.Text != "" && txtcarid.Text != "")
            {



                string mdf = datetimemfd.Value.ToString();
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                SqlCommand cmd = new SqlCommand("update CarManagement set CarID='" + txtcarid.Text + "',CarName='" + txtcarname.Text + "',Category='" + cmbcategory.Text + "',Color='" + txtcolor.Text + "',MfdDate='" + mdf + "',InsuranceNo='" + txtinsurance.Text + "',RegNo='" + txtregno.Text + "',DailyPrice='" + txtdeilyprice.Text + "' where CarID='"+txtcarid.Text+"' ", con);


                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("update completed");
                    con.Close();

                    SqlDataAdapter adt = new SqlDataAdapter("select * from CarManagement", con);
                    DataTable dt = new DataTable();

                    adt.Fill(dt);

                    dgv4.DataSource = dt;

                    txtregno.Text = "";
                    txtinsurance.Text = "";
                    txtdeilyprice.Text = "";
                    txtcolor.Text = "";
                    txtcarname.Text = "";
                    txtcarid.Text = "";



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else if (txtcarid.Text == "")
            {
                MessageBox.Show("CAR ID box is empty please enter the CAR ID");
            }
            else if (txtcarname.Text == "")
            {
                MessageBox.Show("CAR NAMe box is empty please enter the CAR NAME");
            }
            else if (txtcolor.Text == "")
            {
                MessageBox.Show("color box is empty please enter the color");
            }
            else if (txtdeilyprice.Text == "")
            {
                MessageBox.Show("DEILY PRICE box is empty please enter the Deily Price");
            }
            else if (txtinsurance.Text == "")
            {
                MessageBox.Show("INSURANCE NO box is empty please enter the INSURANCE NO ");
            }
            else if (txtregno.Text == "")
            {
                MessageBox.Show("REG NO is empty please enter the REG NO");
            }

            else
            {
                MessageBox.Show("you have mistakes please try again");

                txtregno.Text = "";
                txtinsurance.Text = "";
                txtdeilyprice.Text = "";
                txtcolor.Text = "";
                txtcarname.Text = "";
                txtcarid.Text = "";
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtdeleteandsearch.Text.All(char.IsDigit) && txtdeleteandsearch.Text != "")
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                SqlCommand cmd = new SqlCommand("delete from CarManagement where CarID='" + txtdeleteandsearch.Text + "'", con);


                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("delete complete");
                    con.Close();

                    SqlDataAdapter adt = new SqlDataAdapter("select * from CarManagement", con);
                    DataTable dt = new DataTable();

                    adt.Fill(dt);

                    dgv4.DataSource = dt;

                    txtdeleteandsearch.Text = "";





                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (txtdeleteandsearch.Text == "")
            {
                MessageBox.Show("car Id box is empty please enter the car Id");
            }

            else
            {
                MessageBox.Show("cannot use letter for Car id ");
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtdeleteandsearch.Text.All(char.IsDigit) && txtdeleteandsearch.Text != "")
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                


                try
                {
                    

                    SqlDataAdapter adt = new SqlDataAdapter("select* from CarManagement where CarID='" + txtdeleteandsearch.Text + "'", con);
                    DataTable dt = new DataTable();

                    adt.Fill(dt);

                    dgv4.DataSource = dt;

                    txtdeleteandsearch.Text = "";





                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (txtdeleteandsearch.Text == "")
            {
                MessageBox.Show("car Id box is empty please enter the car Id");
            }

            else
            {
                MessageBox.Show("cannot use letter for Car id ");
            }
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            new home().Show();
            this.Hide();
        }
    }
}
