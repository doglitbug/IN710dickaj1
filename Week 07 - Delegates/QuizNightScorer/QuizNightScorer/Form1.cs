using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizNightScorer
{
    public delegate int ScoreDelegate(int correct, int incorrect);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComputeScore_Click(object sender, EventArgs e)
        {
            ScoreDelegate scoreComputer;
            if (rbAdult.Checked)
            {
                scoreComputer = new ScoreDelegate(Scorer.AdultScore);
            }
            else
            {
                //Must be Child selected
                scoreComputer = new ScoreDelegate(Scorer.ChildScore);
            }

            //Get the scores from the form
            //TODO Catch exceptions etc
            int correct = Int32.Parse(tbCorrect.Text);
            int incorrect = Int32.Parse(tbIncorrect.Text);

            //get score from delegate
            int score = scoreComputer(correct, incorrect);

            //set score on the form
            lblScore.Text = score.ToString();
        }
    }
}
