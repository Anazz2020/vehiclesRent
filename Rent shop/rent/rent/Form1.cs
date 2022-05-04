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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            
            

           
            if (txtusername.Text.All(char.IsLetter)&&txtpassword.Text.All(char.IsDigit))
            {

                if (txtusername.Text =="nibm" && txtpassword.Text == "123")
                {

                    new home().Show();
                    this.Hide();



                }
                else
                {

                    MessageBox.Show("please enter correnct username and password");
                }
            }
            else
            {
                if (txtusername.Text.All(char.IsDigit))
                {
                    MessageBox.Show("cannot use numbers for username");

                }
                else if (txtpassword.Text.All(char.IsLetter))
                {
                    MessageBox.Show("cannot use letters for password");

                }
                else if (txtpassword.Text.All(char.IsLetter) && txtusername.Text.All(char.IsDigit))
                {

                    MessageBox.Show("should enter letters for username and numbers for password");
                }


            }
        }
    }
}
