using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodDeliveryrestart.Services;

// ✅ Keep ONLY this CartItem in the entire project
public class CartItem
{
    public int MenuItemId { get; set; }
    public int RestaurantId { get; set; }
    public string ItemName { get; set; } = "";
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string? ImageUrl { get; set; }
    public int Calories { get; set; }
}

public class CartService
{
    private readonly List<CartItem> _items = new();
    public IReadOnlyList<CartItem> Items => _items;

    // ✅ Notify UI when cart changes
    public event Action? OnChange;
    private void NotifyChanged() => OnChange?.Invoke();

    // ✅ Shared checkout numbers across pages
    public decimal DeliveryFee { get; private set; } = 4.99m;
    public decimal Tip { get; private set; } = 0m;

    public void SetTip(decimal value)
    {
        if (value < 0) value = 0;
        Tip = decimal.Round(value, 2);
        NotifyChanged();
    }

    public void SetDeliveryFee(decimal value)
    {
        if (value < 0) value = 0;
        DeliveryFee = decimal.Round(value, 2);
        NotifyChanged();
    }

    // ✅ Rule: max 3 restaurants per cart
    public bool CanAddRestaurant(int restaurantId)
    {
        var distinctRestaurants = _items.Select(i => i.RestaurantId).Distinct().Count();
        return _items.Any(i => i.RestaurantId == restaurantId) || distinctRestaurants < 3;
    }

    // ✅ Returns false if adding would exceed 3 restaurants
    public bool Add(
        int menuItemId,
        int restaurantId,
        string itemName,
        decimal price,
        string? imageUrl,
        int calories,
        int quantity = 1)
    {
        if (quantity <= 0) quantity = 1;

        if (!CanAddRestaurant(restaurantId))
            return false;

        var existing = _items.FirstOrDefault(i => i.MenuItemId == menuItemId);

        if (existing is null)
        {
            _items.Add(new CartItem
            {
                MenuItemId = menuItemId,
                RestaurantId = restaurantId,
                ItemName = itemName ?? "Item",
                Price = price,
                Quantity = quantity,
                ImageUrl = imageUrl,
                Calories = calories
            });
        }
        else
        {
            existing.Quantity += quantity;
        }

        NotifyChanged();
        return true;
    }

    public void SetQuantity(int menuItemId, int newQty)
    {
        var item = _items.FirstOrDefault(i => i.MenuItemId == menuItemId);
        if (item is null) return;

        if (newQty <= 0)
        {
            Remove(menuItemId);
            return;
        }

        item.Quantity = newQty;
        NotifyChanged();
    }

    public void Remove(int menuItemId)
    {
        _items.RemoveAll(i => i.MenuItemId == menuItemId);
        NotifyChanged();
    }

    public void Clear()
    {
        _items.Clear();
        Tip = 0m; // optional reset
        NotifyChanged();
    }

    public int Count() => _items.Sum(i => i.Quantity);
    public decimal Subtotal() => _items.Sum(i => i.Price * i.Quantity);
    public decimal Total() => Subtotal() + DeliveryFee + Tip;

    public int TotalCalories() => _items.Sum(i => i.Calories * i.Quantity);
}
