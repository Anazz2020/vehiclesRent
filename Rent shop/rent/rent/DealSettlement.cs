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
    public partial class DealSettlement : Form
    {
        public DealSettlement()
        {
            InitializeComponent();
            combocalled();
        }

        void combocalled()
        {

            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlDataAdapter adt = new SqlDataAdapter("select Name from customerManagement", con);
            DataTable dt = new DataTable();
            adt.Fill(dt);

            cmbcus.DataSource = dt;
            cmbcus.DisplayMember = "Name";
        }

        private void DealSettlement_Load(object sender, EventArgs e)
        {
            pnl2.Visible = false;
        }

        private void btndeal_Click(object sender, EventArgs e)
        {
            pnl2.Visible = true;
            pnl1.Visible = false;
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            pnl2.Visible = false;
            pnl1.Visible = true;
        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");


                SqlCommand cmd = new SqlCommand("delete from BookingManagement where CustomerName= '" + cmbcus.Text + "'", con);


                SqlCommand cmd1 = new SqlCommand("delete from customerManagement where Name= '" + cmbcus.Text + "'", con);


                SqlDataAdapter adt = new SqlDataAdapter("select * from BookingManagement where CustomerName= '" + cmbcus.Text + "'", con);
                DataTable dt = new DataTable();
                adt.Fill(dt);

                dataGridView1.DataSource = dt;

                string bID = dataGridView1.Rows[0].Cells[1].ToString();
                string cusname = dataGridView1.Rows[0].Cells[2].ToString();
                string tot = dataGridView1.Rows[0].Cells[3].ToString();
                string rdate = dataGridView1.Rows[0].Cells[4].ToString();
                string returndate = dataGridView1.Rows[0].Cells[5].ToString();
                string car = dataGridView1.Rows[0].Cells[6].ToString();

                SqlCommand cmd2 = new SqlCommand("insert into DealRecord(BookingID,CustomerName,TotalAmount,RentDate,ReturnDate,Car)values('" + bID + "','" + cusname + "','" + tot + "','" + rdate + "','" + returndate + "','" + car + "')", con);





                con.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();


                MessageBox.Show("Deal settelment is completed");
                con.Close();

                SqlDataAdapter adt1 = new SqlDataAdapter("select * from DealRecord", con);
                DataTable dx = new DataTable();
                adt1.Fill(dx);

                dataGridView1.DataSource = dx;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




           
        }

        private void btndis_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                SqlDataAdapter adt1 = new SqlDataAdapter("select * from DealRecord", con);
                DataTable dx = new DataTable();
                adt1.Fill(dx);

                dataGridView1.DataSource = dx;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                SqlCommand cmd = new SqlCommand("delete from DealRecord where BookingID= '" + txtdel.Text + "'", con);

                con.Open();
                MessageBox.Show("Delete completed");
                con.Close();

                SqlDataAdapter adt = new SqlDataAdapter("select * from DealRecord", con);
                DataTable dt = new DataTable();
                adt.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
