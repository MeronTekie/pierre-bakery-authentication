using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Pierre.Models;
using System.Collections.Generic;
using System.Linq;

namespace  Pierre.Controllers
{
  public  class FlavorsController : Controller
  {
    private readonly PierreContext _db;
    public FlavorsController(PierreContext db)
    {
      _db =db;
    }
    public ActionResult Index()
    {
      List<Flavor> model =_db.Flavors.ToList();
      return View(model);
    }
  }
  
}