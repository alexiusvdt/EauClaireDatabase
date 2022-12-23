using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public string Name { get; set; }
    public int StylistId { get; set; }
    // collection navigation property: ref to related entity
    public List<Client> Clients { get; set; }   
  }
}