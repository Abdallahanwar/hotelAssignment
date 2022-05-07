using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotelAssignment.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace hotelAssignment.Data
{
    public class MyWebApiContext:DbContext
    {

        public MyWebApiContext(DbContextOptions<MyWebApiContext> options) : base(options) { }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<City> Cities { get; set; }

    }

}
