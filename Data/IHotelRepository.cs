using System.Threading.Tasks;
using hotelAssignment.Data.Entities;


namespace hotelAssignment.Data
{
    public interface IHotelRepository
    {
        Task<Hotel[]> GetAllHotelsAsync();
        Task<Hotel[]> GetHotelsByName(string name);
        Task<Hotel> GetHotelById(int id);   
    }
}