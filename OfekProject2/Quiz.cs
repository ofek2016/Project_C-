using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OfekProject
{
    public partial class Quiz : Form
    {
        string user;
        int correct = 0;
        List<Question> questions_type1 = new List<Question>();
        List<Question> questions_type2 = new List<Question>();
        Question qut2;
        Question[] randomed = new Question[10];

        public Quiz(string user)
        {
            InitializeComponent();
            this.user = user;
            Init();
        }
        static Random r = new Random();
        void Init()
        {
            //get clean lines
            string[] lines = File.ReadAllLines(@"DATA/gameData.txt");
            int count = 0;
            for (int i = 0; i < lines.Length; i++)
                if (lines[i] != "")
                    count++;
            string[] removed_blank = new string[count];
            for (int i = 0; i < lines.Length; i++)
                if (lines[i] != "")
                    removed_blank[i] = lines[i];
            lines = removed_blank;

            //init questions list
            for (int i = 0; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(';');
                string number = line[0];
                string type = line[1];
                string content = line[2];
                Question q = new Question()
                {
                    Num = line[0].Trim(),
                    Type = line[1].Trim(),
                    Content = line[2].Trim(),
                    Correct = line[3].Trim()
                };
                if (q.Type == "0")
                    questions_type1.Add(q);
                if (q.Type == "2")
                    questions_type2.Add(q);
            }

            //random 10 unique numbers
            int[] random_10_numbers = Enumerable.Range(1, questions_type1.Count).OrderBy(g => Guid.NewGuid()).Take(10).ToArray();
            for (int i = 0; i < random_10_numbers.Length; i++)
                randomed[i] = questions_type1.ElementAt(random_10_numbers[i] - 1);


            int random_qtype2 = r.Next(0, questions_type2.Count);

            Question qu = questions_type2.ElementAt(random_qtype2);
            qut2 = qu;
            DrawToGui(randomed, qu);
        }

        // write questions to form
        void DrawToGui(Question[] randomed, Question qut2)
        {
            label2.Text = qut2.Content;
            pictureBox1.BackgroundImage = Image.FromFile(@"QIMAGES/" + qut2.Correct);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            for (int i = 0; i < randomed.Length; i++)
            {
                if (randomed[i].Type == "0")
                {
                    if (i == 0)
                    {
                        label1.Text = randomed[i].Content;
                    }
                    if (i == 1)
                    {
                        label3.Text = randomed[i].Content;
                    }
                    if (i == 2)
                    {
                        label4.Text = randomed[i].Content;
                    }
                    if (i == 3)
                    {
                        label5.Text = randomed[i].Content;
                    }
                    if (i == 4)
                    {
                        label6.Text = randomed[i].Content;

                    }
                    if (i == 5)
                    {
                        label7.Text = randomed[i].Content;
                    }
                    if (i == 6)
                    {
                        label8.Text = randomed[i].Content;
                    }
                    if (i == 7)
                    {
                        label9.Text = randomed[i].Content;
                    }
                    if (i == 8)
                    {
                        label10.Text = randomed[i].Content;
                    }
                }


            }
        }
        //clear checkboxes
        private void Again_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            correct = 0;
        }

        private void New_Click(object sender, EventArgs e)
        {
            Init();
        }
        // finish quiz
        private void Finish_Click(object sender, EventArgs e)
        {
            string res = "";
            for (int i = 0; i < randomed.Length; i++)
            {
                if (i == 0)
                {
                    if (checkBox1.Checked && randomed[i].Correct == "Y" || !checkBox1.Checked && randomed[i].Correct == "N")
                    {
                        res += "answer "+(i+2)+ ": correct \n";
                        correct += 1;
                    }
                    else
                    {
                        res += "answer " + (i + 2) + ": not correct \n";
                    }


                }
                if (i == 1)
                {
                    if (checkBox2.Checked && randomed[i].Correct == "Y" || !checkBox2.Checked && randomed[i].Correct == "N")
                    {
                        res += "answer " + (i + 2) + ": correct \n";
                        correct += 1;
                    }
                    else
                    {
                        res += "answer " + (i + 2) + ": not correct \n";
                    }
                }
                if (i == 2)
                {
                    if (checkBox3.Checked && randomed[i].Correct == "Y" || !checkBox3.Checked && randomed[i].Correct == "N")
                    {
                        res += "answer " + (i + 2) + ": correct \n";
                        correct += 1;
                    }
                    else
                    {
                        res += "answer " + (i + 2) + ": not correct \n";
                    }
                }
                if (i == 3)
                {
                    if (checkBox4.Checked && randomed[i].Correct == "Y" || !checkBox4.Checked && randomed[i].Correct == "N")
                    {
                        res += "answer " + (i + 2) + ": correct \n";
                        correct += 1;
                    }
                    else
                    {
                        res += "answer " + (i + 2) + ": not correct \n";
                    }
                }
                if (i == 4)
                {
                    if (checkBox5.Checked && randomed[i].Correct == "Y" || !checkBox5.Checked && randomed[i].Correct == "N")
                    {
                        res += "answer " + (i + 2) + ": correct \n";
                        correct += 1;
                    }
                    else
                    {
                        res += "answer " + (i + 2) + ": not correct \n";
                    }
                }
                if (i == 5)
                {
                    if (checkBox6.Checked && randomed[i].Correct == "Y" || !checkBox6.Checked && randomed[i].Correct == "N")
                    {
                        res += "answer " + (i + 2) + ": correct \n";
                        correct += 1;
                    }
                    else
                    {
                        res += "answer " + (i + 2) + ": not correct \n";
                    }
                }
                if (i == 6)
                {
                    if (checkBox7.Checked && randomed[i].Correct == "Y" || !checkBox7.Checked && randomed[i].Correct == "N")
                    {
                        res += "answer " + (i + 2) + ": correct \n";
                        correct += 1;
                    }
                    else
                    {
                        res += "answer " + (i + 2) + ": not correct \n";
                    }
                }
                if (i == 7)
                {
                    if (checkBox8.Checked && randomed[i].Correct == "Y" || !checkBox8.Checked && randomed[i].Correct == "N")
                    {
                        res += "answer " + (i + 2) + ": correct \n";
                        correct += 1;
                    }
                    else
                    {
                        res += "answer " + (i + 2) + ": not correct \n";
                    }

                }
                if (i == 8)
                {
                    if (checkBox9.Checked && randomed[i].Correct == "Y" || !checkBox9.Checked && randomed[i].Correct == "N")
                    {
                        res += "answer " + (i + 2) + ": correct \n";
                        correct += 1;
                    }
                    else
                    {
                        res += "answer " + (i + 2) + ": not correct \n";
                    }
                }
            }

            MessageBox.Show(res);

            string out_path = @"outdata_" + DateTime.Now.ToString("yyyy_MM_ddTHH_mm_ss") + ".txt";
            File.WriteAllText(out_path, user + "\n ansewered " + res + " correct ansewrs");
        }
    }
}
