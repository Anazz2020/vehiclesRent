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
    public partial class Booking_Management : Form
    {
        public Booking_Management()
        {
            InitializeComponent();
            combo();
        }

        void combo()
        {

            SqlConnection con4 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlCommand cmd = new SqlCommand("select * from customerManagement", con4);
            SqlDataAdapter adt = new SqlDataAdapter("select Name from customerManagement",con4);
            DataTable dt = new DataTable();

            adt.Fill(dt);
            cmbcus.DataSource = dt;
            cmbcus.DisplayMember = "Name";

            SqlDataAdapter ax = new SqlDataAdapter("select CarName from CarManagement",con4);
            DataTable dx = new DataTable();

            ax.Fill(dx);

            cmbcar.DataSource = dx;

            cmbcar.DisplayMember = "CarName";
            
        }

        private void Booking_Management_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            cmbcar.Items.Clear();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if (txtbookinid.Text.All(char.IsDigit) && txtamount.Text.All(char.IsDigit) && txtamount.Text != "" && txtbookinid.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                    string rd = rentdate.Value.ToString();
                    string red = returndate.Value.ToString();

                    SqlCommand cmd = new SqlCommand("insert into BookingManagement(BookingID,CustomerName,TotalAmount,RentDate,ReturnDate,car) values('" + txtbookinid.Text + "','" + cmbcus.Text + "','" + txtamount.Text + "','" + rd + "','" + red + "','"+cmbcar.Text+"')", con);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("insert");

                    con.Close();

                    SqlDataAdapter adt = new SqlDataAdapter("select * from BookingManagement", con);
                    DataTable dt = new DataTable();

                    adt.Fill(dt);

                    dgv3.DataSource = dt;

                    txtbookinid.Text = "";
                    txtamount.Text = "";
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (txtamount.Text == "")
            {

                MessageBox.Show("Total Amount box is empty please enter ");


            }
            else if (txtbookinid.Text == "")
            {
                MessageBox.Show("booking id box is empty please enter");
            }
            else if (txtamount.Text.All(char.IsLetter))
            {
                MessageBox.Show("cannot use letter for total amount");
                txtamount.Text = "";
            }
            else if (txtbookinid.Text.All(char.IsLetter))
            {
                MessageBox.Show("cannot use letter for Booking ID");
                txtbookinid.Text = "";



            }
            else
            {
                MessageBox.Show("you have mistake please try agian");
                txtbookinid.Text = "";
                txtamount.Text = "";
            }
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            if (txtbookinid.Text.All(char.IsDigit) && txtamount.Text.All(char.IsDigit) && txtamount.Text != "" && txtbookinid.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                    string rd = rentdate.Value.ToString();
                    string red = returndate.Value.ToString();

                    SqlCommand cmd = new SqlCommand("update BookingManagement set BookingID = '"+txtbookinid.Text+"',CustomerName = '"+cmbcus.Text+"',TotalAmount = '"+txtamount.Text+"',RentDate = '"+rd+"',ReturnDate = '"+red+"',car='"+cmbcar.Text+"' where BookingID= '"+txtbookinid.Text+"'",con); 

                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("update completed");

                    con.Close();

                    SqlDataAdapter adt = new SqlDataAdapter("select * from BookingManagement", con);
                    DataTable dt = new DataTable();

                    adt.Fill(dt);

                    dgv3.DataSource = dt;

                    txtbookinid.Text = "";
                    txtamount.Text = "";
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (txtamount.Text == "")
            {

                MessageBox.Show("Total Amount box is empty please enter ");


            }
            else if (txtbookinid.Text == "")
            {
                MessageBox.Show("booking id box is empty please enter");
            }
            else if (txtamount.Text.All(char.IsLetter))
            {
                MessageBox.Show("cannot use letter for total amount");
                txtamount.Text = "";
            }
            else if (txtbookinid.Text.All(char.IsLetter))
            {
                MessageBox.Show("cannot use letter for Booking ID");
                txtbookinid.Text = "";



            }
            else
            {
                MessageBox.Show("you have mistake please try agian");
                txtbookinid.Text = "";
                txtamount.Text = "";
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;

            


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        

        private void btncancel_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void btnsearchside_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;

            try
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");


                

               

                SqlDataAdapter adt = new SqlDataAdapter("select* from BookingManagement where BookingID='" + txtser.Text + "'", con);
                DataTable dt = new DataTable();

                adt.Fill(dt);

                dgv3.DataSource = dt;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
           

        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            
            
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                    

                    SqlCommand cmd = new SqlCommand("delete from BookingManagement where BookingID='"+txtdel.Text+"'",con);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("delete completed");

                    con.Close();

                    SqlDataAdapter adt = new SqlDataAdapter("select * from BookingManagement", con);
                    DataTable dt = new DataTable();

                    adt.Fill(dt);

                    dgv3.DataSource = dt;

                   
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
            
            

                


            
            
            



           
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                
                

              
                

               

                SqlDataAdapter adt = new SqlDataAdapter("select*from BookingManagement where BookingId= '" +txtser.Text + "'", con);
                DataTable dt = new DataTable();

                adt.Fill(dt);

                dgv3.DataSource = dt;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndis_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

            SqlDataAdapter adt = new SqlDataAdapter("select*from BookingManagement", con);
            DataTable dt = new DataTable();

            adt.Fill(dt);

            dgv3.DataSource = dt;
        }

        private void txtdel_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }

