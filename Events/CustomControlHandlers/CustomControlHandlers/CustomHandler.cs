using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlHandlers
{    
    public class CustomHandler
    {
        //Properties of the handler
        private int codeNumber;
        private Button subject;

        public CustomHandler(Button subject, Random rng)
        {
            this.subject = subject;
            codeNumber = rng.Next(100);

            subject.Click+=new System.EventHandler(this.Handler);
        }

        public void Handler(object sender, EventArgs e)
        {
            //Hold output message while being built
            String message="";

            //Build message
            message += "This is a custom handler.\n";
            message += "My code number is " + codeNumber + "\n";
            message += "My type is " + this.GetType() + "\n";
            message += "I am responding to button:" + (sender as Button).Name + "\n";

            //TODO Check for names in original demo
            MessageBox.Show(message);
            
        }
    }
}
