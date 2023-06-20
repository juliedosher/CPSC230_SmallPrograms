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

        private void MiBMI_Click(object sender, EventArgs e)                                            // Form > BMI Calculator
        {                                      
            FormBMI form = new FormBMI();
            form.ShowDialog();                                                                          // launches new form as modal
        }

        private void MiPassGen_Click(object sender, EventArgs e)                                        // Form > Password Generator
        {
            FormPassGen form = new FormPassGen();
            form.ShowDialog();                                                                          // launches new form as modal
        }

        private void MiWordCount_Click(object sender, EventArgs e)                                      // Form > Word Counter
        {
            FormWordCount form = new FormWordCount();
            form.ShowDialog();                                                                          // launces new form as modal
        }

        private void MiExit_Click(object sender, EventArgs e)                                           // File > Exit
        {
            Close();                                                                                    // closes program
        }

        private void BtnExit_Click(object sender, EventArgs e)                                          // Exit button: closes program
        {
            Close();
        }

        private void MiHelp_Click(object sender, EventArgs e)                                           
        {
            MessageBox.Show("\"Small Programs Showcase\" by Julie Dosher \nfor CPSC 23000 " +
                "Summer 2023");
        }

        // automatically generated functions
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
