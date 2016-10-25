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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Login = new Login();
            Login.Show();

            this.Hide();

            //Form1 f2 = new Form1();
            //f2.con.Open();
            //OleDbCommand cmd = new OleDbCommand(" update  patient set pname = @pname, pcity = @pcity, pcountry = @pcountry where pid = '" + comboBox1.Text + "'", f2.con);
            //cmd.Parameters.AddWithValue("pname", textBox1.Text);
            //cmd.Parameters.AddWithValue("pcity", textBox2.Text);
            //cmd.Parameters.AddWithValue("pcountry", textBox3.Text);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Data  has been Updated", "Inerted", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //f2.con.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {
            Form Login = new Login();
            Login.Show();

            this.Hide();
        }
    }
}
