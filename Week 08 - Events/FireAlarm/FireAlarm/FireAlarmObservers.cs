using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FireAlarm
{
    /// <summary>
    /// Observer to provide instructions
    /// </summary>
    public class InstructionsObserver:FireAlarmObserverBase
    {
        /// <summary>
        /// Constuctor, passes argument straight to parent which will register
        /// </summary>
        /// <param name="subject">Subject to observe</param>
        public InstructionsObserver(FireAlarmSubject subject) : base(subject) { }

        /// <summary>
        /// Method that is executed when event is fired
        /// </summary>
        /// <param name="fireSubject">Subject that fired event</param>
        /// <param name="fe">Event arguments</param>
        public override void FireAlarmHandlerMethod(object fireSubject, FireAlarmEventArgs fe)
        {
            String message = "Fire is " + fe.FireCategory.ToString() + ". ";
            switch (fe.FireCategory)
            {
                case EFireCategory.MINOR:
                    message += "Use a fire extinguisher.";
                    break;
                case EFireCategory.SERIOUS:
                    message += "Call the Fire Department.";
                    break;
                case EFireCategory.INFERNO:
                    message += "Evacuate immediately!!!!!";
                    break;
            }
            MessageBox.Show(message);
        }
    }

    ///////////////////////////////////////////////////////////////////////////

    /// <summary>
    /// Observer to provide audio feedback
    /// </summary>
    public class BeepObserver : FireAlarmObserverBase
    {
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int freq, int duration);
         /// <summary>
        /// Constuctor, passes argument straight to parent which will register
        /// </summary>
        /// <param name="subject">Subject to observe</param>
        public BeepObserver(FireAlarmSubject subject) : base(subject) { }

        /// <summary>
        /// Method that is executed when event is fired
        /// </summary>
        /// <param name="fireSubject">Subject that fired event</param>
        /// <param name="fe">Event arguments</param>
        public override void FireAlarmHandlerMethod(object fireSubject, FireAlarmEventArgs fe)
        {
            switch (fe.FireCategory)
            {
                case EFireCategory.MINOR:
                    Beep(200, 1000);
                    break;
                case EFireCategory.SERIOUS:
                    Beep(400, 1000);
                    break;
                case EFireCategory.INFERNO:
                    Beep(800, 1000);
                    break;
            }
        }
    }
}