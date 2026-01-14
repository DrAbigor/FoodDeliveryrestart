using System.Collections.Generic;
using System.Linq;

namespace FoodDeliveryrestart.Services;

public record CartItem(int MenuItemId, string ItemName, decimal Price, int Quantity);

public class CartService
{
    private readonly List<CartItem> _items = new();

    public IReadOnlyList<CartItem> Items => _items;

    public void Add(int menuItemId, string itemName, decimal price, int quantity = 1)
    {
        var existing = _items.FirstOrDefault(i => i.MenuItemId == menuItemId);
        if (existing is null)
            _items.Add(new CartItem(menuItemId, itemName, price, quantity));
        else
        {
            _items.Remove(existing);
            _items.Add(existing with { Quantity = existing.Quantity + quantity });
        }
    }

    public void Remove(int menuItemId) => _items.RemoveAll(i => i.MenuItemId == menuItemId);
    public void Clear() => _items.Clear();
    public int Count() => _items.Sum(i => i.Quantity);
    public decimal Total() => _items.Sum(i => i.Price * i.Quantity);
}
