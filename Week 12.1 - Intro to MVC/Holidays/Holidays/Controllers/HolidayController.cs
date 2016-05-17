using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Holidays.Models;

namespace Holidays.Controllers

{
    public class HolidayController : Controller
    {
        //
        // GET: /Index/
        public ActionResult Index()
        {
            //Hold known holidays
            List<Holiday> holidays = new List<Holiday>();

            //Add holidays
            holidays.Add(new Holiday("Queen's Birthday",6,6,"queensBirthday.jpg"));//Mondayization here...
            holidays.Add(new Holiday("Halloween", 31, 10, "halloween.jpg"));
            holidays.Add(new Holiday("Boxing Day", 26, 12, "boxingDay.jpg"));

            //Choose a holiday at random
            Random rng = new Random();
            int holidayIndex = rng.Next(holidays.Count());

            return View(holidays[holidayIndex]);
        }
	}
}