namespace Horecapp.Models;

public class Dish: IStoredObject
{
    public int Id { get; set; }
    public string Name { get; set; }
    public float Price { get; set; }
    public enum Category
    {
        APPETIZER,
        MAIN,
        DESERT,
        VEGE,
        VEGAN
    }
    public string Reference { get; set; }
    //Many to one relationship with Restaurant & Order
    public Restaurant Restaurant { get; set; }
    public Order? Order { get; set; }
}