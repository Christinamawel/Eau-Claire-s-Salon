using System.Collections.Generic;
using System;

namespace HairSalon.Models
{
  public class Appointment
  {
    public int AppointmentId { get; set; }
    public DateTime TimeAndDate { get; set; }
    public Decimal AppointmentCost { get; set; }
    public int Paid { get; set; }
    public int ClientId { get; set; }
    public virtual Client Client { get; set; }
  }
}