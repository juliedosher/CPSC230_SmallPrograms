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

            miBMI.Click += MiBMI_Click;
            miPassGen.Click += MiPassGen_Click;
            miWordCount.Click += MiWordCount_Click;

            miExit.Click += MiExit_Click;
            miHelp.Click += MiHelp_Click;
            btnExit.Click += BtnExit_Click;
        }

        private void MiBMI_Click(object sender, EventArgs e)
        {
            FormBMI form = new FormBMI();
            form.ShowDialog();
        }

        private void MiPassGen_Click(object sender, EventArgs e)
        {
            FormPassGen form = new FormPassGen();
            form.ShowDialog();
        }

        private void MiWordCount_Click(object sender, EventArgs e)
        {
            FormWordCount form = new FormWordCount();
            form.ShowDialog();
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

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
