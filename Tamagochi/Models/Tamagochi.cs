using System;
using System.Collections.Generic;

namespace Tamagochi
  {
    public class Pet
  {
    private string _health;
    private string _hunger;
    private string _play;
    private int _id;
    private static List<Pet> _instances = new List<Pet>{};

    public Pet (string health, string hunger, string play, int id)
    {
     _health = petHealth;
     _hunger = petHunger;
     _play = petPlay;
     _instances.Add(this);
     _id = _instances.Count;
    }

    public string GetPetHealth()
    {
      return _health;
    }

    public void SetPetHealth(string newpetHealth)
    {
      _health = newpetHealth;
    }

    public string GetPetHunger()
    {
      return _hunger;
    }

    public void SetPetHunger(string newpetHunger)
    {
      _hunger = newpetHunger
    }

    public string GetPetPlay()
    {
      return _play;
    }

    public void SetPetPlay(string newpetPlay)
    {
      _play = newpetPlay;
    }

   }
  }
