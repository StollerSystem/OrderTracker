using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> { };
    public string Description { get; set; }
    public int Id { get; }

    public Order(string description)
    {
      Description = description;
      Id = 0;
      _instances.Add(this);
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}