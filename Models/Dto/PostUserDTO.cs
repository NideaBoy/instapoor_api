using MongoDB.Bson.Serialization.Attributes;
namespace instapoor_api.Models;

public class PostUserDTO 
{
    [BsonElement("username")]
    public string username {get; set;}

    [BsonElement("identify")]
    public string identify {get; set;}

    [BsonElement("picture")]
    public string picture {get; set;}
    
    [BsonElement("history")]
    public HistoryModel[]? History {get; set;}
}

