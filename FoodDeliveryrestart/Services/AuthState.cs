namespace FoodDeliveryrestart.Services;

public class AuthState
{
    public bool IsLoggedIn { get; private set; }
    public string? Email { get; private set; }

    public void Login(string email)
    {
        IsLoggedIn = true;
        Email = email;
    }

    public void Logout()
    {
        IsLoggedIn = false;
        Email = null;
    }
}
