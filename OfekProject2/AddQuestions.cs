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

namespace OfekProject
{
    public partial class AddQuestions : Form
    {
        public AddQuestions()
        {
            InitializeComponent();
        }
        string path = @"DATA/gameData.txt";


        private void Add0_Click(object sender, EventArgs e)
        {
            string ans = checkBox1.Checked == true ? "Y" : "N";
            // string row to add
            string row = (GetLineCount() + 1).ToString() + ";" + textBox1.Text + ";" + richTextBox1.Text + ";" + ans;
            File.AppendAllText(path, Environment.NewLine + row);
        }

        private void Add1_Click(object sender, EventArgs e)
        {
            string ans = checkBox2.Checked == true ? "1" : "2";
            string row = (GetLineCount() + 1).ToString() + ";" + textBox2.Text + ";" + textBox3.Text + ";" + textBox4.Text;
            File.AppendAllText(path, Environment.NewLine + row);
        }
        //count how many rows in file there are
        int GetLineCount()
        {
            string[] line = File.ReadAllLines(path);
            int line_count = 15;
            for (int i = 0; i < line.Length; i++)
                if (line[i] != "")
                    line_count++;
            return line_count;
        }

        //browse to image
        private void Dial1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {

                Title = "Browse images Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "jpg",
                Filter = "jpg files (*.jpg)|*.jpg",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label18.Text = Path.GetFileName(openFileDialog1.FileName);
            }
        }

        
        // add question type 2
        private void Add2_Click(object sender, EventArgs e)
        {
            string ans = checkBox4.Checked == true ? "Y" : "N";
            string row = (GetLineCount() + 1).ToString() + ";" + textBox6.Text + ";" + richTextBox2.Text + ";" + label18.Text;
            File.AppendAllText(path, Environment.NewLine + row);
        }

        //add question type 3
        private void Add3_Click(object sender, EventArgs e)
        {
            string ans = checkBox3.Checked == true ? "1" : "2";
            string row = (GetLineCount() + 1).ToString() + ";" + textBox5.Text + ";" + label14.Text + ";" + label15.Text+";"+ans;
            File.AppendAllText(path, Environment.NewLine + row);
        }
        //browse to an image
        private void Dia2_CLick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {

                Title = "Browse images Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "jpg",
                Filter = "jpg files (*.jpg)|*.jpg",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label14.Text = Path.GetFileName(openFileDialog1.FileName);
            }
        }
        //browse to an image
        private void Dial3(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {

                Title = "Browse images Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "jpg",
                Filter = "jpg files (*.jpg)|*.jpg",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label15.Text = Path.GetFileName(openFileDialog1.FileName);
            }
        }
    }
}
