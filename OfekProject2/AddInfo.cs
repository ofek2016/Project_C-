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
    public partial class AddInfo : Form
    {
        public AddInfo()
        {
            InitializeComponent();
        }
        string EXE = Directory.GetParent(System.Reflection.Assembly.GetEntryAssembly().Location).FullName;
        //adding info button
        private void Add_Click(object sender, EventArgs e)
        {
            string[] line = File.ReadAllLines(@"DATA/infoData.txt");
            int line_count = 15;
            for (int i = 0; i < line.Length; i++)
                if (line[i] != "")
                    line_count++;
            //row to add to file
            string row = (line_count + 1).ToString() + ";"+ textBox1.Text+";" + richTextBox1.Text;
            if(image!="")
                row += ";" + image ;
          //load content from file
            File.AppendAllText(@"DATA/infoData.txt", Environment.NewLine+row);
        }

        string image = "";
        //browse to image
        private void Image_Click(object sender, EventArgs e)
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
                label3.Text = openFileDialog1.FileName;
                image = Path.GetFileName(openFileDialog1.FileName);// only file name
            }
        }
    }
}
