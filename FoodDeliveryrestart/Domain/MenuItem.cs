using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryrestart.Domain
{
    public class MenuItem : BaseDomainModel
    {
        public string? ItemName { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }

        // ✅ NEW Nutrition Fields
        public int Calories { get; set; }                 // e.g. 650
        public int CarbohydratesG { get; set; }           // e.g. 65
        public int ProteinG { get; set; }                 // e.g. 28
        public int FatG { get; set; }                     // e.g. 32

        [StringLength(200)]
        public string? Allergens { get; set; }            // e.g. "Dairy, Gluten, Eggs"

        // Dietary Flags
        public bool IsHalal { get; set; }
        public bool IsVegan { get; set; }
        public bool IsNutFree { get; set; }
        public bool IsDairyFree { get; set; }


        // FK
        public int RestaurantId { get; set; }
        public Restaurant? Restaurant { get; set; }
    }
}
