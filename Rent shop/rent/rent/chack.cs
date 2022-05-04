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
    public partial class chack : Form
    {
        public chack()
        {
            InitializeComponent();
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\USER\\Desktop\\c#\\database\\VehicalRsystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                string date = datetime.Value.ToString();

                SqlDataAdapter adt = new SqlDataAdapter("select* from BookingManagement where ReturnDate = '" + date + "'", con);
                DataTable dt = new DataTable();

                adt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
