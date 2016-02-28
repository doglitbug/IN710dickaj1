using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestMovieDatabase
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Database to hold a collection of movies and associated methods
        /// </summary>
        MovieDatabase movieDatabase;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initilize movieDatabase
            movieDatabase = new MovieDatabase();

            //Populate the movieDatabase with some default data

            //Used to hold success message from moviedatabase
            //Not used here because this is sample data(should be no error result)
            String feedback;

            movieDatabase.AddMovie("1961", "West SideStory", "Jerome Robbins", out feedback);
            movieDatabase.AddMovie("1972", "The Godfather", "Francis Ford Coppola", out feedback);
            movieDatabase.AddMovie("1984", "Amadeus", "Milos Forman", out feedback);
            movieDatabase.AddMovie("2007", "No Country for Old Men", "Ethan & Joel Coen", out feedback);
        }

        /// <summary>
        /// Deal with user clicking on Add button
        /// </summary>
        /// <param name="sender">Unused</param>
        /// <param name="e">Unused</param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Collect data from the form
            String inputYear = textBoxAddYear.Text;
            String inputTitle = textBoxAddTitle.Text;
            String inputDirector = textBoxAddDirector.Text;

            //Hold feedback from moviedatabase
            String feedback;
            if (movieDatabase.AddMovie(inputYear, inputTitle, inputDirector, out feedback))
            {
                //Clear out the text boxes as we have been successful
                textBoxAddYear.Clear();
                textBoxAddTitle.Clear();
                textBoxAddDirector.Clear();
            }
            MessageBox.Show(feedback);
        }

        /// <summary>
        /// Deal with user clicking on Delete button
        /// </summary>
        /// <param name="sender">Unused</param>
        /// <param name="e">Unused</param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Collect data from the form
            String inputYear = textBoxDeleteYear.Text;

            //Hold feedback from moviedatabase
            String feedback;
            if (movieDatabase.DeleteMovie(inputYear, out feedback))
            {
                //Clear out the text box as we have been successful
                textBoxDeleteYear.Clear();
            }
            MessageBox.Show(feedback);
        }

        /// <summary>
        /// Deal with user clicking on Search button
        /// </summary>
        /// <param name="sender">Unused</param>
        /// <param name="e">Unused</param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //Collect data from the form
            String inputYear = textBoxSearchYear.Text;

            //Hold feedback from moviedatabase
            String feedback;
            if (movieDatabase.SearchMovie(inputYear, out feedback))
            {
                //Clear out the text box as we have been successful
                textBoxSearchYear.Clear();
            }
            MessageBox.Show(feedback);
        }

        /// <summary>
        /// Deal with user clicking on Print all button
        /// </summary>
        /// <param name="sender">Unused</param>
        /// <param name="e">Unused</param>
        private void buttonPrintAll_Click(object sender, EventArgs e)
        {
            //Clear textBox of previous entries
            textBoxPrintAll.Clear();
            //Ask the movie database for a list of all movies
            textBoxPrintAll.Text = movieDatabase.ToString();
        }
    }
}
