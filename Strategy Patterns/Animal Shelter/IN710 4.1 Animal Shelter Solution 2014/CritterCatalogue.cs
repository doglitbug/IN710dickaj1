﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{

    public class CritterCatalogue
    {
        string inputFileName;
        private List<Critter> critterList;

        //=======================================================================
        // Ctor
        //=======================================================================
        public CritterCatalogue(string inputFileName)
        {
            this.inputFileName = inputFileName;
            critterList = new List<Critter>();
            loadCritterList();
        }

        //=======================================================================
        // Returns a List<Critter> containing all Critters in class member 
        // critterList whose species is equal to the passed in argument.
        // NB: Critter.species is an enum; the passed in argument is a string.
        // Explore System.Enum.Parse for solution.
        //=======================================================================
        public List<Critter> CritterQuery(string speciesName)
        {
            //List of critters to return
            List<Critter> matchingList = new List<Critter>();

            //Find all the matching critters from critterList

            foreach (Critter c in critterList)
            {
                if (c.Species.ToString() == speciesName)
                {
                    //Add to list to return
                    matchingList.Add(c);
                }
            }
            return matchingList;
        }


        //=======================================================================
        // Reads in and parses the text file.
        // Creates a Critter instance for each entry, and loads them into the
        // class member List<Critter> critterList
        //=======================================================================
        private void loadCritterList()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(inputFileName);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Can't find the input file!");
            }

            if (sr != null)
            {
                String currentLine = "";
                String[] currentAnimal;


                while ((currentLine = sr.ReadLine()) != null)
                {
                    currentAnimal = currentLine.Split(',');

                    ESpecies currentSpecies = (ESpecies)System.Enum.Parse(typeof(ESpecies), currentAnimal[1]);
                    critterList.Add(new Critter(currentAnimal[0], currentSpecies));
                } // end for each line
            } // end if sr != null
        } // end loadCritterList

        //=======================================================================
        // Prints critterList to the paseed-in ListBox
        //=======================================================================
        public void PrintAllCritters(ListBox displayBox)
        {
            displayBox.Items.Clear();
            foreach (Critter c in critterList)
            {
                displayBox.Items.Add(c.ToString());
            }
        }



    }
}
