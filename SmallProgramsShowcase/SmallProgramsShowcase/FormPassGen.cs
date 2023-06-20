using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SmallProgramsShowcase
{
    public partial class FormPassGen : Form
    {
        public FormPassGen()
        {
            InitializeComponent();

            btnBrowse.Click += BtnBrowse_Click;
            btnGenerate.Click += BtnGenerate_Click;
            btnClose.Click += BtnClose_Click;
        }

        private void BtnBrowse_Click(object sender, EventArgs e)                                        // Browse button: opens file dialog
        {
            lisPasswords.Items.Clear();                                                                 // clears list of passwords

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "c:\\temp";
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;

            string fileName = "";
            if(ofd.ShowDialog() == DialogResult.OK)                                                     // file was found
            {
                fileName = ofd.FileName;
                rtbFileName.Text = fileName;
            }
            else                                                                                        // if file does not exist
            {
                MessageBox.Show("The file does not exist.");
            }
        }

        private void BtnGenerate_Click(object sender, EventArgs e)                                      // Generate button: create the passwords
        {
            lisPasswords.Items.Clear();                                                                 // clears list of passwords
            int num = 0;
            try
            {
                num = Convert.ToInt32(rtbNum.Text);
                if (num < 1)                                                                            // checks for value of at least 1 or greater
                {
                    MessageBox.Show("The number of words must be a nonzero positive number.");
                }
                else                                                                                    // generates passwords
                {
                    GeneratePasswords(num, rtbFileName.Text);
                }
            }
            catch (Exception)                                                                           // if anything but an integer is entered
            {
                MessageBox.Show("The number of words must be an integer.");
            }
        }

        private string[] GetWords(string fileName)
        {
            string[] words;
            using (StreamReader reader = new StreamReader(fileName))
            {
                Char[] delimiters = { ' ', '\n', '\r' };                                                // splits text file based on spaces and newlines
                words = reader.ReadToEnd().Split(delimiters,
                    StringSplitOptions.RemoveEmptyEntries);
            }

            for (int i = 0; i < words.Length; i++)                                                      // replaces certain characters
            {
                words[i] = words[i].ToLower();

                if (words[i].Contains('s'))
                {
                    words[i] = words[i].Replace('s', '$');                                              // s -> $
                }

                if (words[i].Contains('i'))                                         
                {
                    words[i] = words[i].Replace('i', '!');                                              // i -> !
                }
            }
            return words;
        }

        private void GeneratePasswords(int num, string fileName)
        {
            string[] words = GetWords(fileName);
            Random random = new Random();
            for (int i = 0; i < num; i++)
            {
                int num1 = random.Next(0, words.Length);
                int num2 = random.Next(0, words.Length);
                int num3 = random.Next(0, words.Length);

                string word1 = words[num1];
                string word2 = words[num2].ToUpper();
                string word3 = words[num3];

                lisPasswords.Items.Add(word1 + word2 + word3);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)                                         // Close button: closes form
        {
            Close();
        }
    }
}
