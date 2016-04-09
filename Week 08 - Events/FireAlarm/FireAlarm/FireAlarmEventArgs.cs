using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    public enum EFireCategory { MINOR, SERIOUS, INFERNO};
    public class FireAlarmEventArgs : EventArgs
    {
        /// <summary>
        /// Current category of fire
        /// </summary>
        public EFireCategory FireCategory { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="currentFireCatgeory">Enum for current category</param>
        public FireAlarmEventArgs(EFireCategory currentFireCatgeory){
            FireCategory=currentFireCatgeory;
        }
    }
}
