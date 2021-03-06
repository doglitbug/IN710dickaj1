﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixAndMatch
{
    public partial class Form1 : Form
    {
        CharacterStorage storageEngine;
        public Form1()
        {
            InitializeComponent();
            //Set up storage
            storageEngine = new CharacterStorage();

            //Get a string list of the avaliable characters
            List<string> avaliableCharacters = storageEngine.getListofCharacters();

            //Populate the combo boxes on the form
            foreach (string s in avaliableCharacters)
            {
                //Add characters to combo box
                cbHead.Items.Add(s);
                cbBody.Items.Add(s);
                cbLegs.Items.Add(s);
                //Select first one as default
                cbHead.SelectedIndex = 0;
                cbBody.SelectedIndex = 0;
                cbLegs.SelectedIndex = 0;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Get the named of the individual parts
            string selectedHead = cbHead.SelectedItem.ToString();
            string selectedBody = cbBody.SelectedItem.ToString();
            string selectedLegs = cbLegs.SelectedItem.ToString();

            //Ask storage to make a new character
            Character newCharacter = storageEngine.createCharacterFromSelection(selectedHead, selectedBody, selectedLegs);
            //Create an output engine
            CharacterOutput outputEngine = new CharacterOutput(newCharacter, pbHead, pbBody, pbLegs);
            //Ask it to do its thing
            outputEngine.PrintCharacter();

        }
    }
}