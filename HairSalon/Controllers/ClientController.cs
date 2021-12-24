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

    [HttpGet("index/{id}")]
    public ActionResult Index(int id)
    {
      Client model = _db.Clients.Where(client => client.StylistId == id).FirstOrDefault<Client>();
      return View(model);
    }
  }
}