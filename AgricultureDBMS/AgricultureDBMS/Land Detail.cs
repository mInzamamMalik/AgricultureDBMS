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
    public partial class Land_Detail : Form
    {
        public Land_Detail()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Add_Event_in_Timeline = new Add_Event_in_Timeline();
            Add_Event_in_Timeline.Show();
        }
    }
}
