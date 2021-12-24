using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new Hashset<Client>();
    }

    public int StylistId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}