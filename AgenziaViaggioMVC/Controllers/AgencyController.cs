using Microsoft.AspNetCore.Mvc;
using AgenziaViaggioMVC.Database;
using AgenziaViaggioMVC.Models;



namespace AgenziaViaggioMVC.Controllers
{
    public class AgencyController : Controller
    {

        public IActionResult Index()
        {
            using (AgencyContext db = new AgencyContext())
            {
                List<Trip> TripList = db.Trips.ToList();
                return View("Index", TripList);
            }
       }
    }
}
