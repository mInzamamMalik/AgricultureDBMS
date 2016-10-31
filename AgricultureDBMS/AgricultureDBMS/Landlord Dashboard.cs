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
    public partial class Landlord_Dashboard : Form
    {
        OleDbConnection con = new OleDbConnection();
        public Landlord_Dashboard()
        {
            InitializeComponent();
            //con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ABEER\Documents\Agricultureproject.accdb";
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\waheed\Documents\Agricultureproject.accdb";
        }

        private void Landlord_Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                string query = " select * from Land ";

                cmd.CommandText = query;
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {


                    //for insert
                    label2.Text = reader["Title"].ToString();
                    label3.Text = reader["Location"].ToString();
                    //textbox3.Items.Add(reader["Co_Name"].ToString());

                }


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void panel2_Paint(object sender, EventArgs e)
        {
            Form LandDetail = new Land_Detail();
            LandDetail.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form AddOrEdit = new Add_or_Edit_Land();
            AddOrEdit.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form AddOrEdit = new Add_or_Edit_Land();
            AddOrEdit.Show();
        }
    }
}
