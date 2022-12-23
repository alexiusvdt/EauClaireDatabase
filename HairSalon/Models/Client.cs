namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Name { get; set; }
    public int StylistId { get; set; }
    // reference navigation property, holds a reference to a single related entity
    public Stylist Stylist { get; set;}
  }
}