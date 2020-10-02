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
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int Id)
    {
      return _instances[Id - 1];
    }

  }
}