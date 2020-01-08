using Microsoft.AspNetCore.Mvc;
using Stats.Models;
using System.Collections.Generic;

namespace Tamagotchi.Controllers
{
  public class TamagotchisController : Controller
  {

    [HttpGet("/creatures")]
    public ActionResult Index()
    {
      List<Creature> allCreatures = Creature.GetAll();
      return View(allCreatures);
    }

    [HttpPost("/creatures")]
    public ActionResult Create(int hunger, int attention, int rest, string name)
    {
      Creature newCreature = new Creature(hunger, attention, rest, name);
      return RedirectToAction("Index");
    }

    [HttpPost("/creatures/delete")]
    public ActionResult DeleteAll()
    {
      Creature.ClearAll();
      return View();
    }

    [HttpGet("/creatures/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/creatures/{id}")]
    public ActionResult Show(int id)
    {
      Creature foundCreature = Creature.Find(id);
      return View(foundCreature);
    }    

  }
}