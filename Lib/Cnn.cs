using instapoor_api.Type;
using MongoDB.Driver;

namespace instapoor_api.Lib;

public class Cnn {
    public IConfiguration _configuration;
    public Cnn(IConfiguration configuration) {
        _configuration = configuration;
    }
    public IMongoDatabase DB() {
        var env = _configuration.GetSection("MONGO").Get<ENV>();
        var client = new MongoClient(env.CNN);
        var db =  client.GetDatabase("instapoor");
        
        return db;
    }
}