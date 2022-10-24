namespace Client.Models;

public class Order
{
    public int RestaurantId { get; set; }
    public IEnumerable<int> Foods { get; set; }
    public int Priority { get; set; }
    public int MaxWait { get; set; }
    public DateTime CreateOnTime { get; set; }
}