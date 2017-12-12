using GigHub.Models;
using GigHub.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace GigHub.Controllers
{
    public class GigsController : Controller
    {
        // Create the default DbContext
        private ApplicationDbContext _context;

        //Initialize the DbContext on the constructor
        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Gigs
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                //Set the Genres to the models and pass it to list
                Genres = _context.Genres.ToList()
            };

            //return the view model instead of the view
            return View(viewModel);
        }
    }
}