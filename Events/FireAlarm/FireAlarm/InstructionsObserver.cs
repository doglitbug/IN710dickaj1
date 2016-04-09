using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireAlarm
{
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
}
