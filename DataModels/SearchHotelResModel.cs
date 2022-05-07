using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelAssignment.DataModels
{
    public class SearchHotelResModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double StarRating { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int NumberOfRooms { get; set; }
        public string CityName { get; set; }
        public string CityLocation { get; set; }

    }
}
