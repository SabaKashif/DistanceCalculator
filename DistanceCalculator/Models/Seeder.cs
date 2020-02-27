using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DistanceCalculator.Models
{
    public class Seeder
    {
        private ApplicationDBContext _context;

        public Seeder(ApplicationDBContext context) 
        {
            _context = context;
        }

        public void Seed()
        {
            _context.Database.EnsureCreated();
            if (_context.geoPoints.Any()) 
            {
                return;
            }

            var distance = new GeoPoint[] 
            {
                new GeoPoint{City= "Islamabad", Latitude=33.7214813, Longitude=73.0432892},
                new GeoPoint{City= "Lahore", Latitude=31.5580006, Longitude=74.350708}
            };

            foreach(GeoPoint g in distance)
            {
                _context.AddRange();
                _context.SaveChanges();
            }
        }
    }
}
