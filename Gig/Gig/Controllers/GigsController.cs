﻿using Gig.Models;
using Gig.ViewModels;
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
                Genres = _context.Genres.ToList()
            };

            return View(viewModel);
        }
    }
}