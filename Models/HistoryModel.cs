using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace instapoor_api.Models;

public class HistoryModel 
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string id { get; set; }

    [BsonElement("content")]
    public string[] content {get; set;}

    [BsonElement("like")]
    public int like {get; set;}
}