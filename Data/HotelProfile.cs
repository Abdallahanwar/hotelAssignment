using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using hotelAssignment.Data.Entities;
using hotelAssignment.DataModels;

namespace hotelAssignment.Data
{
    public class HotelProfile : Profile
    {   
        public HotelProfile()
        {
            this.CreateMap<Hotel, SearchHotelResModel>();
        }
    }
}
