using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string Description { get; set; }
    public Order(string description)
    {
      Description = "test";
    }
  }
}