using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryrestart.Domain
{
    public class Restaurant : BaseDomainModel
    {
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [StringLength(50)]
        public string? CuisineType { get; set; }

        [StringLength(50)]
        public string? OperatingHours { get; set; }

        [StringLength(50)]
        public string? LocationWithinMall { get; set; }
        public string? ImageUrl { get; set; }


        // NEW
        [Range(0, 5)]
        public decimal Rating { get; set; } = 0m;

        // NEW
        public BusyLevel BusyLevel { get; set; } = BusyLevel.Low;

        // FK
        public int MallId { get; set; }
        public Mall? Mall { get; set; }

        public ICollection<MenuItem>? MenuItems { get; set; }
    }
}
