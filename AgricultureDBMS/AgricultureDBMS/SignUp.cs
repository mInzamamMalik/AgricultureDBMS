using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AgricultureDBMS
{
    public partial class SignUp : Form
    {
        OleDbConnection con = new OleDbConnection();

        public SignUp()
        {
            InitializeComponent();
            //con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ABEER\Documents\Agricultureproject.accdb";
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\waheed\Documents\Agricultureproject.accdb";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Close();
            Login f = new Login();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pasword.Text == confrmpaswordtxt.Text)
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO Users (user_name,user_password,user_contact,user_surname,user_age,user_location) values ('" + user_name.Text + "','" + pasword.Text + "','" + emailtxt.Text + "','" + sur_nametxt.Text + "','" + agetxt.Text + "','" + locationtxt.Text + "')";

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("you have been successfully registered!.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //MessageBox.Show("Successfully Registered!");
                    con.Close();

                    //refresh
                    user_name.Text = "";
                    pasword.Text = "";
                    emailtxt.Text = "";
                    sur_nametxt.Text = "";
                    agetxt.Text = "";
                    locationtxt.Text = "";
                    confrmpaswordtxt.Text = "";
                    Login f = new Login();
                    f.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

            }
            else
            {
                
                //MessageBox.Show("Password not match!");
                MessageBox.Show(" Password not match! please try again.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                confrmpaswordtxt.Text = "";

            }
        }
    }
    }

