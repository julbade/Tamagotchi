using System;
using System.Collections.Generic;

namespace Tamagochi.Models
  {
    public class Pet
  {
    private int _feed;
    private int _play;
    private int _sleep;
    private string _name;
    private string _image;
    private int _skipTime;
    private int _health;
    private int _id;
    private static List<Pet> _instances = new List<Pet>{};


    public Pet (string petName, string petImage)
    {
      _name = petName;
      _image = petImage;
     _instances.Add(this);
     _id = _instances.Count;
     _health = 100;
     _sleep = 20;
     _play = 20;
     _feed = 20;
     _skipTime = 0;
    }
    public void SetPetPlay(int play)
    {
      _play = play;
    }

    public int GetPetPlay()
    {
      return _play;
    }

    public void SetPetHealth(int health)
    {
      _health = health;
    }

    public int GetPetHealth()
    {
      return _health;
    }
    public int GetTimeSkip()
    {
      return _skipTime;
    }
    public void SetTimeSkip(int timeskip)
    {
      _skipTime = timeskip;
    }

    public int GetPetFeed()
    {
      return _feed;
    }

    public void SetPetFeed(int feed)
    {
      _feed = feed;
    }

    public int GetPetSleep()
    {
      return _sleep;
    }

    public void SetPetSleep(int sleep)
    {
      _sleep = sleep;
    }

    public string GetPetName()
    {
      return _name;
    }

    public void SetPetName(string petName)
    {
      _name = petName;
    }
    public string GetPetImage()
    {
      return _image;
    }
    public void SetPetImage(string petImage)
    {
      _image = petImage;
    }


    public void IncreaseFeed()
    {
      this.SetPetFeed(this.GetPetFeed() + 10);
    }
    public void Sleep()
    {
      this.SetPetHealth(this.GetPetHealth() + 10);
    }
    public void IncreaseAttention()
    {
      this.SetPetPlay(this.GetPetPlay() + 10);
    }
    public void KillPet()
    {
      this.SetPetHealth(this.GetPetHealth() - 50);
    }

    public int GetId()
    {
      return _id;
    }

    public static List<Pet> GetPet()
    {
      return _instances;
    }
    public void Save()
    {
     _instances.Add(this);
    }

    public static void ClearPet()
    {
      _instances.Clear();
    }

    public static Pet Find(int searchId)
    {
      return _instances[searchId-1];
    }

    }
   }
