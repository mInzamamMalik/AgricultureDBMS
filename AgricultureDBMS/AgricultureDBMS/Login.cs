using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgricultureDBMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2();
            //f2.con.Open();
            //OleDbCommand cmd = new OleDbCommand("select pid from patient", f2.con);
            //OleDbDataReader dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{
            //    this.comboBox1.Items.Add(dr["pid"].ToString());
            //}
            //f2.con.Close();
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
            Form DashBoard = new Landlord_Dashboard();
            DashBoard.Show();

            this.Hide();
        }
    }
}
