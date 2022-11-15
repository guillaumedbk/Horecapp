namespace Horecapp.Domain.Models;

public class Restaurant: IStoredObject
{
    public int Id { get; set; }
    public string Name { get; set; }
    public enum Type
    {
        GASTRONOMIC,
        ITALIAN,
        FRITERIE,
        PITA,
        CHINESE,
        KOREAN
    }
    public string Address { get; set; }
    public string City { get; set; }
    public int PostalCode { get; set; }
    public string Country { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string TvaNumber { get; set; }
    //One to many relationship with Dish & Order
    public ICollection<Dish>? Dish { get; set; }
    public ICollection<Order>? Order { get; set; }
}