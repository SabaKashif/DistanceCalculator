using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DistanceCalculator.Models
{
    public class ApplicationDBContext: DbContext
    {
        private readonly IConfigurationRoot _config;

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options, IConfigurationRoot config)
        {
            _config = config;
        }

        public DbSet<GeoPoint> geoPoints { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config["ConnectionString"]);
        }
    }
}
