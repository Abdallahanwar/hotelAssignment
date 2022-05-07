using hotelAssignment.Data.Entities;
using hotelAssignment.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using AutoMapper;
using hotelAssignment.DataModels;

namespace hotelAssignment.Controllers
{
    [Route("api/[Controller]/[Action]")] 
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelRepository _repo;
        private readonly IMapper _mapper;

        public HotelController(IHotelRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet("{name?}")]
        public async Task<ActionResult<SearchHotelResModel[]>> SearchHotels(string name)
        {
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    var results = await _repo.GetAllHotelsAsync();
                    return _mapper.Map<SearchHotelResModel[]>(results);
                }
                else
                {
                    var results = await _repo.GetHotelsByName(name);
                    if (results == null) return NotFound();
                    return _mapper.Map<SearchHotelResModel[]>(results);
                }
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<SearchHotelResModel>> GetHotelById(int id)
        {
            try
            {
                var results = await _repo.GetHotelById(id);
                if (results == null) return NotFound();
                return _mapper.Map<SearchHotelResModel>(results);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

     

    }
}
