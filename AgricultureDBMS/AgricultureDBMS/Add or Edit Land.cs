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
    public partial class Add_or_Edit_Land : Form
    {
        OleDbConnection con = new OleDbConnection();
        public Add_or_Edit_Land()
        {
            InitializeComponent();
            //con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ABEER\Documents\Agricultureproject.accdb";
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\waheed\Documents\Agricultureproject.accdb";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO land (Title,Location) values ('" + textBox3.Text + "','" + textBox4.Text + "')";

                cmd.ExecuteNonQuery();
                MessageBox.Show("you have been successfully add new land!.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("Successfully Registered!");
                con.Close();
                Add_or_Edit_Land f = new Add_or_Edit_Land();
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }
        
    }
}
    