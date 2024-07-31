using instapoor_api.Lib;
using instapoor_api.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace instapoor_api.Controllers;

[Route("/post/content")]
public class PostController
{
    Cnn _db;
    public PostController(Cnn db)
    {
        _db = db;
    }
    [HttpGet]
    [Route("{limit}")]
    public dynamic GetProfile(string limit)
    {
        var post = _db.DB().GetCollection<PostModel>("post");
        var ConvertedLimit = Int32.Parse(limit);
        var rest = post.Find<PostModel>(d => true).Limit(ConvertedLimit).ToList();
        return rest;
    }
}