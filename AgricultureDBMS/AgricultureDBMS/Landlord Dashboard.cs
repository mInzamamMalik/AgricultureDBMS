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
    public partial class Landlord_Dashboard : Form
    {
        public Landlord_Dashboard()
        {
            InitializeComponent();
        }

        private void Landlord_Dashboard_Load(object sender, EventArgs e)
        {

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
