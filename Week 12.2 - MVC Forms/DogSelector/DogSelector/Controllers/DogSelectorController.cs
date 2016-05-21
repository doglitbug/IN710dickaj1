using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DogSelector.Models;

namespace DogSelector.Controllers
{
    public class DogSelectorController : Controller
    {
        //
        // GET: /DogSelector/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Dog searchDog)
        {
            //Create new database(this seems pretty inefficient)
            DatabaseManager db = new DatabaseManager();

            //Ask database for a dog based on the details provided from the user
            
            //TODO Choose a dog in here from what has been provided!
            Dog suggestedDog = db.suggestDog(searchDog);

            //Display results to user
            return View("Suggestion", suggestedDog);
        }
	}
}