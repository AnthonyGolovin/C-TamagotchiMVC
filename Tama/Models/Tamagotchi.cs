using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Creature
  {
    public int Hunger = 100;
    public int Attention = 100;
    public int Rest = 100;
    public string Name{ get; set; }
    public int Id { get; }
    private static List<Creature> _instances = new List<Creature> { };
    // Button button1 = new Button ();
    // button1.Text = "Feed";
    // Button button2 = new Button ();
    // Button button3 = new Button ();
   

    public Creature(int hunger, int attention, int rest, string name)
    {
        Hunger = hunger;
        Attention = attention;
        Rest = rest;
        Name = name;
        _instances.Add(this);
        Id = _instances.Count;
    }

    public static List<Creature> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Creature Find(int searchId)
        {
            return _instances[searchId - 1];
        }

    // public void Playeractions()
    // {
    //   switch(input)
    //   {
    //     case "f":
    //             Hunger += 10;
    //             Attention -= 7;
    //             Rest -=4;
    //             Console.WriteLine("\n\n\nHunger: " + Hunger + " Thirst: " + Attention + " Sunlight: " + Rest + "\n");
    //             break;
    //         case "w":
    //             Hunger -= 2;
    //             Attention += 10;
    //             Rest -=7;
    //             Console.WriteLine("\n\n\nHunger: " + Hunger + " Thirst: " + Attention + " Sunlight: " + Rest + "\n");
    //             break;
    //         case "s":
    //             Hunger -= 6;
    //             Attention -= 9;
    //             Rest +=10;
    //             Console.WriteLine("\n\n\nHunger: " + Hunger + " Thirst: " + Attention + " Sunlight: " + Rest + "\n");
    //             break;
    //         default:
    //             Console.WriteLine("Invalid Input");
    //             Playeraction();
    //             break;
    //   }
    // }

    // public int Feed()
    // {

    // }
    // public int Play()
    // {

    // }
    // public int Sleep()
    // {

    // }
  
  }
}