using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using hotelAssignment.Data;
using hotelAssignment.Data.Entities;
using Microsoft.AspNetCore.Hosting;

namespace hotelAssignment.Data
{
    public class MyWebApiSeeder
    {
        private readonly MyWebApiContext _ctx;
        private readonly IWebHostEnvironment _hosting;

        public MyWebApiSeeder(MyWebApiContext ctx, IWebHostEnvironment hosting)
        {
            _ctx = ctx;
            _hosting = hosting;
        }

        public void Seed()
        {
            _ctx.Database.EnsureCreated();

             if (!_ctx.Hotels.Any())
             {
             var file = Path.Combine(_hosting.ContentRootPath, "Data/database.json");
              var json = File.ReadAllText(file);
              var hotels = JsonSerializer.Deserialize<IEnumerable<Hotel>>(json);
              _ctx.Hotels.AddRange(hotels);


            _ctx.SaveChanges();
            }
        }
    }
}

