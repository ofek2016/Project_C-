using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfekProject
{
    public partial class Form2 : Form
    {
        string user;
        public Form2(string user)
        {
            InitializeComponent();
            this.user = user;
        }
        //navigate to learn
        private void Lear_CLick(object sender, EventArgs e)
        {
            new LearnForm().Show();
        }
        //navigate to quiz
        private void Quiz_Click(object sender, EventArgs e)
        {
            new Quiz(user).Show();
        }
        //navigate to add question
        private void Add_Q_Click(object sender, EventArgs e)
        {
            new AddQuestions().Show();
        }
        //navigate to add data
        private void Add_Info_Click(object sender, EventArgs e)
        {
            new AddInfo().Show();
        }
    }
}
