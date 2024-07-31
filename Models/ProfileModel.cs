using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace instapoor_api.Models;

public class ProfileModel
{   
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public ObjectId id { get; set; }
    
    [BsonElement("username")]
    public string username {get; set;}
    
    [BsonElement("identify")]
    public string identify {get; set;}
    
    [BsonElement("picture")]
    public string picture {get; set;}

    [BsonElement("post")]
    public ObjectId[] post { get; set; }

    [BsonElement("history")]
    public HistoryModel[]? History {get; set;}

}