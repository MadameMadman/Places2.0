using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Places.Models;

namespace Places.Controllers
{
    public class PlacesController : Controller
    {
        [HttpGet("/places")]
        public ActionResult Index()
        {
            List<Place> allPlaces = Place.GetAll();
            return View(allPlaces);
        }

        [HttpGet("/places/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/places")]
        public ActionResult Create()
        {
            Place newPlace = new Place(
            Request.Form["newCity"],
            Request.Form["newState"],
            Request.Form["newDescription"]);
            List<Place> model = Place.GetAll();
            return View("Index", model);
        }

        [HttpPost("/places/delete")]
        public ActionResult DeleteAll()
        {
            Place.ClearAll();
            return View();
        }

        [Produces("text/html")]
        [Route("/place_photos")]
        public ViewResult PlacePhotos()
        {
            return View();
        }

        [HttpGet("/places/{id}")]
        public ActionResult Details(int id)
        {
          Place place = Place.Find(id);
          return View(place);
        }

    }
}
