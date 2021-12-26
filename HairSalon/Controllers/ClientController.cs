using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HairSalon.Controllers
{
  public class ClientController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientController(HairSalonContext db)
    {
      _db = db;
    }

    [HttpGet("Index/{id}")]
    public ActionResult Index(int id)
    {
      List<Client> model = _db.Clients.Where(client => client.StylistId == id).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index", "Stylist");
    }

    [HttpGet("Details/{id}")]
    public ActionResult Details(int id)
    {
      ViewBag.ClientId = id;
      List<Appointment> model = _db.Appointments.Where(appointment => appointment.ClientId == id).ToList();
      return View(model);
    }
  }
}