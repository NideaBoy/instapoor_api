using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace instapoor_api.Models;

public class PostModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public ObjectId id { get; set; }

    [BsonElement("alt")]
    public string? alt { get; set; }

    [BsonElement("like")]
    public int like { get; set; }

    [BsonElement("time_created")]
    public DateTime time_created { get; set; }

    [BsonElement("coment")]
    public PostComentDTO[]? coment { get; set; }

    [BsonElement("content")]
    public string[] content { get; set; }

    [BsonElement("user")]
    public PostUserDTO user { get; set; }
}