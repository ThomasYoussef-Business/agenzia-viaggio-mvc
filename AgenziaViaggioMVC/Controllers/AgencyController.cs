using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AgenziaViaggioMVC.Database;
using AgenziaViaggioMVC.Models;
using System.Diagnostics;



namespace AgenziaViaggioMVC.Controllers
{
    public class AgencyController : Controller
    {

        public IActionResult Index()
        {
            using (AgencyContext db = new AgencyContext())
            {
                List<Trip> TripList = db.Trips.ToList<Trip>();
                return View("Index", TripList);
            }

        }
    }
}
