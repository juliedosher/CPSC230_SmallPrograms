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
    public partial class FormBMI : Form
    {
        public FormBMI()
        {
            InitializeComponent();

            btnClose.Click += BtnClose_Click;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
