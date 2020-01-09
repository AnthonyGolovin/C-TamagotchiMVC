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

    

    public (int, int, int) Feed()
    {
        return (this.Hunger += 10, this.Attention -= 10, this.Rest -= 10);
    }
    public (int, int, int) Play()
    {
        return (this.Hunger -= 10, this.Attention += 10, this.Rest -= 10);
    }
    public (int, int, int) Sleep()
    {
        return (this.Hunger -= 10, this.Attention -= 10, this.Rest += 10);
    }
  
  }
}