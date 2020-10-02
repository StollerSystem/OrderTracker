using System.Collections.Generic;


namespace OrderTracker.Models
{
  public class Vendor 
  {
    public string Name { get; set; }
    public int Id { get; set; }

    public static void ClearAll()
    {
      // _instances.Clear();
    }

    public Vendor(string name)
    {
      Name = name;
      Id = 1;
    }
  }
}