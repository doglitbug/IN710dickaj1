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
        private IMachineMaker machineMaker;
        private ListBox displayBox;

        public MachineSpecPrinter(IMachineMaker machineMaker, ListBox displayBox)
        {
            this.machineMaker = machineMaker;
            this.displayBox = displayBox;
        }

        public void PrintSpec()
        {
            Component currentCPU = machineMaker.makeCPU();
            Component currentRAM = machineMaker.makeRAM();
            Component currentGFX = machineMaker.makeGFX();

            double totalPrice = currentCPU.Price + currentRAM.Price + currentGFX.Price;

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
