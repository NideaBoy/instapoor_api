using MongoDB.Bson.Serialization.Attributes;

namespace instapoor_api.Models;

public class PostComentDTO {
    
    [BsonElement("message")]
    public string message { get; set; } 

    [BsonElement("respond")]
    public PostRespondDTO[]? respond { get; set; } 

    [BsonElement("user")]
    public PostUserDTO user { get; set; } 
}

public class PostRespondDTO {
    [BsonElement("message")]
    public string message { get; set; } 
    
    [BsonElement("to")]
    public string to { get; set; } 

    [BsonElement("user")]
    public PostUserDTO user { get; set; } 
    
} 