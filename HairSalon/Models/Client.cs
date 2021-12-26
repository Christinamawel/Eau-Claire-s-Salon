using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Client
  {
    public Client()
    {
      this.Appointment = new HashSet<Appointment>{};
    }

    public int ClientId { get; set; }
    public string Name { get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
    public virtual ICollection<Appointment> Appointment { get; set; }
  }
}