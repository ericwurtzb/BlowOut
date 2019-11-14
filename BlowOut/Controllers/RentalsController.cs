using BlowOut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class RentalsController : Controller
    {
        //https://github.com/nax3t/webdevbootcamp/blob/master/YelpCamp/v1/app.js
        public static List<Rental> rentalList = new List<Rental>()
        {
            new Rental {rentalID = 1, rentalName = "Trumpet", newPrice = 55, usedPrice = 25, picture = "/Content/instruments/trumpet.jpg"},
            new Rental {rentalID = 2, rentalName = "Trombone", newPrice = 60, usedPrice = 35, picture = "/Content/instruments/trombone.jpg"},
            new Rental {rentalID = 3, rentalName = "Tuba", newPrice = 70, usedPrice = 50, picture = "/Content/instruments/tuba.jpg"},
            new Rental {rentalID = 4, rentalName = "Flute", newPrice = 40, usedPrice = 25, picture = "/Content/instruments/flute.jpg"},
            new Rental {rentalID = 5, rentalName = "Clarinet", newPrice = 35, usedPrice = 27, picture = "/Content/instruments/clarinet.jpg"},
            new Rental {rentalID = 6, rentalName = "Saxophone", newPrice = 42, usedPrice = 30, picture = "/Content/instruments/sax.jpg"},
        };

        // GET: Rentals
        public ActionResult Index()
        {
            return View(rentalList);
        }

        // GET: Rentals/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Rentals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rentals/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rentals/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Rentals/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rentals/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Rentals/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
