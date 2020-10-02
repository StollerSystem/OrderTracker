using System.Collections.Generic;


namespace OrderTracker.Models
{
  public class Vendor 
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string Name { get; set; }
    public int Id { get; set; }    

    public Vendor(string name)
    {
      Name = name;
      Id = 1;
    }


    public static void ClearAll()
    {
      // _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }
  }
}