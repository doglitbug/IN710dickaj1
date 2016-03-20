using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomBuiltPCs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Current type of machine
        /// </summary>
        IMachineMaker currentMachine;
        private void btnPrintSpec_Click(object sender, EventArgs e)
        {
            //Find out what type of machine we want from form
            if (rbGame.Checked)
            {
                currentMachine = new GameMachineMaker();
            }
            else if (rbBusiness.Checked)
            {
                currentMachine = new BusinessMachineMaker();
            }
            else if (rbMultimedia.Checked)
            {
                currentMachine = new MultimediaMachineMaker();
            }
            else
            {
                currentMachine = new BudgetMachineMaker();
            }
            //TODO Add new machine types in here when adding radiobuttons

            //Use a spec printer to decouple the output from the generation of computer
            //Adding a new component 'type' will require changes to theinterface, inherited makers and the printer
            //Adding a new machine type will require changes to this form
            //Adding new components requires changes to the makers that use it only

            //Make a machine spec printer and output the specs
            MachineSpecPrinter currentSpecPrinter = new MachineSpecPrinter(currentMachine, listBoxDisplay);
            currentSpecPrinter.PrintSpec();
        }
    }
}
