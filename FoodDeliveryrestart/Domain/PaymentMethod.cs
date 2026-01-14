namespace FoodDeliveryrestart.Domain;

public class PaymentMethod : BaseDomainModel
{
    public string? CardType { get; set; }
    public int ExpiryMonth { get; set; }
    public int ExpiryYear { get; set; }
    public string? CardHolderName { get; set; }

    // Foreign Key
    public int UserId { get; set; }

    // Navigation
    public User? User { get; set; }
    public ICollection<Payment> Payments { get; set; } = new HashSet<Payment>();
}