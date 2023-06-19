using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallProgramsShowcase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            miExit.Click += MiExit_Click;
            miHelp.Click += MiHelp_Click;
            btnExit.Click += BtnExit_Click;
        }

        private void MiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MiHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\"Small Programs Showcase\" by Julie Dosher \nfor CPSC 23000 " +
                "Summer 2023");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
