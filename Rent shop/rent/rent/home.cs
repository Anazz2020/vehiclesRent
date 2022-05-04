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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
            combo();
            combo1();
        }

        void combo()
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlDataAdapter adt = new SqlDataAdapter("select CarName from CarManagement",con);
            DataTable dt = new DataTable();
            adt.Fill(dt);

            cmbcarname.DataSource = dt;
            cmbcarname.DisplayMember = "CarName";

        }

        void combo1()
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlDataAdapter adt = new SqlDataAdapter("select Name from customerManagement", con);
            DataTable dt = new DataTable();
            adt.Fill(dt);

            cmbcus.DataSource = dt;
            cmbcus.DisplayMember = "Name";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new vehicle_category().Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new customermanagement().Show();
            this.Hide();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Booking_Management().Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new CarManagement().Show();
            this.Hide();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnser_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                SqlDataAdapter adt = new SqlDataAdapter("select * from BookingManagement where car='" + cmbcarname.Text + "'", con);
                DataTable dt = new DataTable();
                adt.Fill(dt);

                dataGridView1.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    lblavailable.Visible = true;
                    lblavailable.Text = "AVAILABLE";


                }
                else
                {
                    lblavailable.Text="NOT AVAILABLE";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlDataAdapter adt = new SqlDataAdapter("select * from customerManagement where Name='" +cmbcus.Text+"'", con);

            DataTable dt = new DataTable();
            adt.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void btndeal_Click(object sender, EventArgs e)
        {
            new DealSettlement().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new chack().Show();

        }
    }
}
