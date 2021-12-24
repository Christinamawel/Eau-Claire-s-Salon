using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Appointment
  {
    public int AppointmentId { get; set; }
    public DateTime TimeAndDate { get; set; }
    public int AppointmentCost { get; set; }
    public int Paid { get; set; }
  }
}