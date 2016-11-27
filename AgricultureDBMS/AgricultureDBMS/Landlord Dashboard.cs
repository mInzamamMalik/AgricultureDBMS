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
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Agricultureproject.accdb";
        }

        private void Landlord_Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                int pointX = 30;
                int pointY = 40;
                panel5.Controls.Clear();

                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                string query = " select * from Land ";

                cmd.CommandText = query;
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {                        
                        
                       
                        
                            PictureBox pbox = new PictureBox();
                            pbox.Image = Properties.Resources.pomegranate_anar_250x250;
                            pbox.Size = new Size(256, 100);
                            pbox.Location = new Point(pointX, pointY);

                            Label l1 = new Label();
                            Label l2 = new Label();

                            l1.BorderStyle = BorderStyle.None;
                            l2.BorderStyle = BorderStyle.None;

                            l1.Text = reader["Title"].ToString();                            
                            l2.Text = reader["Location"].ToString();
                            
                            l1.Location = new Point(pointX, pointY+10);
                            l2.Location = new Point(pointX, pointY+20);

                            pbox.SendToBack();
                            l1.BringToFront();
                            

                            pbox.Click += abc;
                               
                            


                            panel5.Controls.Add(pbox);
                            panel5.Controls.Add(l1);
                            panel5.Controls.Add(l2);
                            panel5.Show();
                            pointY += 125;
                            
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(e.ToString());
                    }



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

        private void abc(object sender, EventArgs e)
        {
            Form opendetail = new Land_Detail();
            opendetail.Show();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
