using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;  
using Stats.Models;

namespace Tamagotchi.Controllers
{
  public class HomeController : Controller
  {
      [Route("/")]
      public ActionResult Index() 
      { 
        return View(); 
      }

      [Route("/List")]//
      public ActionResult Tamagotchi() 
      {
          // Creature newCreature = new Creature(hunger, attention, rest, name);

           return View(); }

  }
}