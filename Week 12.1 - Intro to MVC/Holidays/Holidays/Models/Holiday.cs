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
            this.date = new DateTime(DateTime.Now.Year, month, day);
            this.imageName = imageName;
        }
    }
}