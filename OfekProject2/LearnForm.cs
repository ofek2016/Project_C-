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
    public partial class LearnForm : Form
    {
        public LearnForm()
        {
            InitializeComponent();
            Init();
        }
        // load content from file and show it on text box
       void Init()
        {
            string[] lines = File.ReadAllLines(@"DATA/infoData.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(';');
                if (line.Length > 1)
                {
                    DataItem di = new DataItem()
                    {
                        Num = line[0],
                        Header = line[1],
                        Text = line[2]
                    };
                    richTextBox1.AppendText(line[0] + ". " + line[2] + Environment.NewLine);
                }
                else
                    richTextBox1.AppendText(Environment.NewLine);
            }
        }
    }
}
