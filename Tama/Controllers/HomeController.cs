using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;  
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
  public class HomeController : Controller
  {
      [Route("/")]
      public ActionResult Index() 
      { 
        return View(); 
      }

  }
}