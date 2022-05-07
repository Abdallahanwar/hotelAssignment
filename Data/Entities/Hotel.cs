using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelAssignment.Data.Entities
{
    public class Hotel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        [Column(TypeName = "varchar(200)")]
        public string Name { get; set; }
        public double? StarRating { get; set; }
        public int NumberOfRooms { get; set; }  
        public string Image { get; set;}
        public string Description { get; set; }
        public City City { get; set; }
    }
}
