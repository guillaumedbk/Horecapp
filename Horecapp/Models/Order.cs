namespace Horecapp.Models;

public class Order: IStoredObject
{
    public int Id { get; set; }
    public float Price { get; set; }
    public DateTime OrderedAt { get; set; }
    //Many to one with Restaurant
    public Restaurant Restaurant { get; set; }
}