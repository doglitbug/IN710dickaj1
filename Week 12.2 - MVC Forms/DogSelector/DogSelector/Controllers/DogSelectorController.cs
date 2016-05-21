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
            //TODO Choose a dog in here from what has been provided!
            Dog suggestedDog = new Dog()
            {
                BreedName = "BichonFrise",
                DisplayName = "Bichon Frise",
                ActivityLevel = Dog.EScale.High,
                CoatLength = Dog.ELength.Medium,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = Dog.EScale.High,
                IntelligenceLevel = Dog.EScale.High,
                SheddingLevel = Dog.EScale.Low,
                Size = Dog.ESize.Small,
                ImageName = "Bichonfrise.jpg"
            };

            return View("Suggestion", suggestedDog);
        }
	}
}