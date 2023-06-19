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

            btnCalc.Click += BtnCalc_Click;
            btnClose.Click += BtnClose_Click;
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                int weight = Convert.ToInt32(tbWeight.Text);
                int height = Convert.ToInt32(tbHeight.Text);

                if (height < 0 || weight < 0)
                {
                    MessageBox.Show("The mass and height must be positive numbers.");
                }
                else
                {
                    double bmi = CalculateBMI(weight, height);
                    string status = GetStatus(bmi);

                    rtbBMI.Text = bmi.ToString("0.##");
                    rtbStatus.Text = status;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The mass and height must be integers.");
            }
            
        }

        private double CalculateBMI(int weightLb, int heightIn)
        {
            double weight = weightLb * 0.45359237;
            double height = heightIn * 0.0254;

            return weight / (height * height);
        }

        private string GetStatus(double bmi)
        {
            string bmiClass = "";
            if (bmi < 18.5)
            {
                bmiClass = "underweight";
            }

            else if (bmi < 25)
            {
                bmiClass = "normal weight";
            }

            else if (bmi < 30)
            {
                bmiClass = "overweight";
            }

            else
            {
                bmiClass = "obese";
            }

            return bmiClass;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
