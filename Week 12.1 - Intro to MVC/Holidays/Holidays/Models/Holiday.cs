using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Holidays.Models
{
    public class Holiday
    {
        /// <summary>
        /// Name of the holiday
        /// </summary>
        public String name { get; set; }

        /// <summary>
        /// Date of the holiday
        /// </summary>
        public DateTime date { get; set; }

        /// <summary>
        /// Contains the filename of the image to show
        /// </summary>
        public String imageName { get; set; }

        /// <summary>
        /// Find out how many days until this holiday occurs
        /// </summary>
        /// <returns>Number of days until holiday occurs</returns>
        public int daysUntil()
        {
            //TODO Stubbed out
            return 5;
        }
    }
}