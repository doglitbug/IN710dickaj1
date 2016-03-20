using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomBuiltPCs
{
    class MachineSpecPrinter
    {
        /// <summary>
        /// Current machinemaker
        /// </summary>
        private IMachineMaker machineMaker;
        /// <summary>
        /// Output listbox
        /// </summary>
        private ListBox displayBox;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="machineMaker">Machine maker</param>
        /// <param name="displayBox">Where to output specs</param>
        public MachineSpecPrinter(IMachineMaker machineMaker, ListBox displayBox)
        {
            this.machineMaker = machineMaker;
            this.displayBox = displayBox;
        }

        /// <summary>
        /// Print out details on current machine
        /// </summary>
        public void PrintSpec()
        {
            ///Make the components(in their types)
            CPU currentCPU = machineMaker.makeCPU();
            RAM currentRAM = machineMaker.makeRAM();
            GFX currentGFX = machineMaker.makeGFX();

            //Calculate price
            double totalPrice = currentCPU.Price + currentRAM.Price + currentGFX.Price;

            //Display
            displayBox.Items.Clear();
            displayBox.Items.Add("Price\tComponent");
            displayBox.Items.Add("------------------------------------------------");

            displayBox.Items.Add(currentCPU.ToString());
            displayBox.Items.Add(currentRAM.ToString());
            displayBox.Items.Add(currentGFX.ToString());

            displayBox.Items.Add("------------------------------------------------");
            displayBox.Items.Add("Total price: "+totalPrice.ToString());
        }
    }
}
