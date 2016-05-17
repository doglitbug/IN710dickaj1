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
        /// Day of the holiday
        /// </summary>
        public int day { get; set; }

        /// <summary>
        /// Month of the holiday
        /// </summary>
        public int month { get; set; }

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
            //Get time now
            DateTime now = DateTime.Now;
            //Get time of holiday
            DateTime holiday = new DateTime(now.Year, month, day);
            //Hold difference between the two
            TimeSpan difference;

            //Check to see if it has already passed this year!
            if (holiday < now)
            {
                holiday.AddYears(1);
                difference = holiday.Subtract(now);
            }
            else
            {
                difference = holiday.Subtract(now);
            }
                return difference.Days;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name of the holiday</param>
        /// <param name="day">Day of the month</param>
        /// <param name="month">Month of the year</param>
        /// <param name="imageName">Filename of the image</param>
        public Holiday(String name, int day, int month, String imageName)
        {
            this.name = name;
            //TODO Check for invalid date here
            this.day = day;
            this.month = month;
            this.imageName = imageName;
        }
    }
}