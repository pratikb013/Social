using Gig.Models;
using Gig.ViewModels;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;

namespace Gig.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

       

        public ActionResult Create()
        {
            var viewModel = new GigForm
            {
                //datasoucre for the genre dropdownlist 
                Genres = _context.Genres.ToList()
            };

            return View(viewModel);
        }

        //authorize attribute will ensure anly the authentic user will create the gig and it will be associated with it.
        [HttpPost]
        public ActionResult Create(GigForm viewModel)
        {
            //we are getting the userId information from the ApplicationUser
            var artistId = User.Identity.GetUserId();
            var artist = _context.Users.Select(m => m.Id == artistId);

            var gig = new GigHub
            {

            };
            
            return View();
        }
    }
}