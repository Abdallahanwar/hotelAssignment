using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotelAssignment.Data.Entities;
using hotelAssignment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace hotelAssignment.Data
{
    public class HotelRepository : IHotelRepository
    {
        private readonly MyWebApiContext _context;
        private readonly ILogger<HotelRepository> _logger;

        public HotelRepository(MyWebApiContext context, ILogger<HotelRepository> logger)
        {
            _context = context;
            _logger = logger;
        }


        public async Task<Hotel[]> GetAllHotelsAsync()
        {
            IQueryable<Hotel> query = _context.Hotels
                .Include(c => c.City);


            return await query.ToArrayAsync();
        }

        public async Task<Hotel[]> GetHotelsByName(string name)
        {
            IQueryable<Hotel> q = _context.Hotels
                    .Where(p => p.City.Name.ToLower().Contains(name.ToLower()) ||
                    p.Name.ToLower().Contains(name.ToLower()))
                    .Include(c => c.City);



            return await q.ToArrayAsync();

        }

        public async Task<Hotel> GetHotelById(int id)
        {
            var q = _context.Hotels.Where(i => i.Id == id)
                .Include(c => c.City);



            return await q.FirstOrDefaultAsync();

        }
    }
}
