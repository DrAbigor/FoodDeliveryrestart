namespace FoodDeliveryrestart.Domain;

public class Payment
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime PaymentDate { get; set; }
    public string? PaymentStatus { get; set; }

    public decimal Amount { get; set; }
    public int OrderId { get; set; }

    // Foreign Key
    public int PaymentMethodId { get; set; }
    public int UserId { get; set; }

    // Navigation (singular and nullable)
    public PaymentMethod? PaymentMethod { get; set; }

    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
    public string? CreatedBy { get; set; }
    public string? UpdatedBy { get; set; }
}