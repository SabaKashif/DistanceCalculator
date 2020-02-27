using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DistanceCalculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace DistanceCalculator.Controllers
{
    public class GeoPointController : Controller
    {
        private readonly ApplicationDBContext _context;
        public GeoPointController(ApplicationDBContext context)
        {
            _context = context;
        }
  
        public IActionResult Index()
        {
           var model= _context.geoPoints.ToList();
            return View(model);
        }
    }
}