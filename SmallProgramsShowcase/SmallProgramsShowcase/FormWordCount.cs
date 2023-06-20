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
    public partial class FormWordCount : Form
    {
        public FormWordCount()
        {
            InitializeComponent();

            btnCount.Click += BtnCount_Click;
            btnClose.Click += BtnClose_Click;
        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
            lisCount.Items.Clear();
            Char[] delimiters = { ' ', '\n', '\r', ',', '.', ':', ';' };
            string[] words = rtbStory.Text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToLower();
            }

            if (words.Length > 0)
            {
                Dictionary<string, int> wordCount = GetWordCount(words);
                wordCount = AlphabetizeDictionary(wordCount);
                foreach (var word in wordCount)
                {
                    lisCount.Items.Add(word.Key + ": " + word.Value);
                }
        }
            else
            {
                MessageBox.Show("Please enter a story first.");
            }
        }

        private Dictionary<string, int> GetWordCount(string[] words)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (wordCount.ContainsKey(words[i]))
                {
                    wordCount[words[i]]++;
                }

                else
                {
                    wordCount.Add(words[i], 1);
                }
            }
            return wordCount;
        }

        private static Dictionary<string, int> AlphabetizeDictionary(Dictionary<string, int> originalDict)
        {
            var orderedWords = new Dictionary<string, int>();

            var list = originalDict.Keys.ToList();                                                  
            list.Sort();

            foreach (var word in list)
            {
                orderedWords.Add(word, originalDict[word]);
            }

            return orderedWords;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
