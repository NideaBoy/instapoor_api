using instapoor_api.Lib;
using instapoor_api.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
namespace instapoor_api.Controllers;

[Route("/users")]
public class ProfileController 
{
    Cnn _db;
    public ProfileController(Cnn db)
    {
        _db = db;
    }
    [HttpGet]
    public dynamic GetProfile() {
        var profile = _db.DB().GetCollection<ProfileModel>("profile");
        var rest = profile.Find(d => true).ToList();
        return rest;
    }
}