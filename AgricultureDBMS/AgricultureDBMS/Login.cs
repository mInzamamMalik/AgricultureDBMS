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
    public partial class Login : Form
    {
        OleDbConnection con = new OleDbConnection();

        public Login()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Agricultureproject.accdb";
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form SignupForm = new Form1();
            SignupForm.Show();

            this.Hide();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(user_name.Text))
            {
                MessageBox.Show("please enter your user name","Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                user_name.Focus();
                return;
            }
            try
            {
                

                AgricultureprojectDataSetTableAdapters.UsersTableAdapter user = new AgricultureprojectDataSetTableAdapters.UsersTableAdapter();
                AgricultureprojectDataSet.UsersDataTable dt = user.GetDataByusernamepassword(user_name.Text, pasword.Text);
                if(dt.Rows.Count>0)
                {
                    MessageBox.Show("you have been successfully logged in.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //process your login here
                    Landlord_Dashboard.userName = user_name.Text;
                    Form DashBoard = new Landlord_Dashboard();
                    DashBoard.Show();
                }
                else
                {
                    MessageBox.Show("Your username or password is incorrect.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form login = new Login();
                    login.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

          

            this.Hide();
        }

        private void user_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                pasword.Focus();
        }

        private void pasword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                login_btn.PerformClick();
                
                
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SignUp f = new SignUp();
            f.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
