using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HairSalon.Controllers
{
  public class AppointmentController : Controller
  {
    private readonly HairSalonContext _db;

    public AppointmentController(HairSalonContext db)
    {
      _db = db;
    }

    [HttpGet("Create/{id}")]
    public ActionResult Create(int id)
    {
      ViewBag.Client = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      return View();
    }

    [HttpPost("Create/{id}")]
    public ActionResult Create(Appointment app)
    {
      _db.Appointments.Add(app);
      _db.SaveChanges();
      return RedirectToAction("Index", "Stylist");
    }
  }
}