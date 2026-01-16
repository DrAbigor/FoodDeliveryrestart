using FoodDeliveryrestart.Domain;

public class PaymentMethod : BaseDomainModel
{
    public string? CardType { get; set; }
    public int ExpiryMonth { get; set; }
    public int ExpiryYear { get; set; }
    public string? CardHolderName { get; set; }

    public int UserId { get; set; }
    public User? User { get; set; }
    public ICollection<Payment> Payments { get; set; } = new HashSet<Payment>();

}
