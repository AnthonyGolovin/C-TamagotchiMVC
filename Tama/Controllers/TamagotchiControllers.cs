using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;

namespace Tamagotchi.Controllers
{
  public class TamagotchiController : Controller
  {

    [HttpGet("/tamagotchi")]
    public ActionResult Index()
    {
      List<Creature> allCreatures = Creature.GetAll();
      return View(allCreatures);
    }

    [HttpPost("/tamagotchi")]
    public ActionResult Create(string name)
    {
      Creature newCreature = new Creature(name);
      return RedirectToAction("Index");
    }

    [HttpPost("/tamagotchi/delete")]
    public ActionResult DeleteAll()
    {
      Creature.ClearAll();
      return View();
    }

    [HttpGet("/tamagotchi/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/tamagotchi/{id}")]
    public ActionResult Show(int id)
    {
      Creature foundCreature = Creature.Find(id);
      return View(foundCreature);
    }    

  }
}