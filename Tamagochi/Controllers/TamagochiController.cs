using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Tamagochi.Models;

namespace Tamagochi.Controllers
{
public class PetController : Controller
{

  [HttpGet("/pet")]
  public ActionResult Index()
  {
    List<Pet> allPet = Pet.GetPet();
    return View(allPet);

  }

  [HttpGet("/pet/new")]
  public ActionResult AddPetForm()
  {
    return View();
  }

  [HttpPost("/pet")]
  public ActionResult Create()
  {
      Pet newPet = new Pet(Request.Form["pet-name"], Request.Form["pet-image"]);
      List<Pet> allPet = Pet.GetPet();
      return View("Index", allPet);
  }

  [HttpPost("pet/delete")]
  public ActionResult DeleteAll()

  {
    Pet.ClearPet();
    return View();
  }

  [HttpGet("/pet/{id}")]
    public ActionResult PetInteractions(int id)
    {
      Pet pet = Pet.Find(id);
      return View(pet);

    }
 }
}
