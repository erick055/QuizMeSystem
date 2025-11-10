using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMe_
{
    public partial class Flashcards : Form
    {
        public Flashcards()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Dashboard2 dashboard = new Dashboard2();
            this.Hide();

            dashboard.Show();
        }
    }
}
