using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace SMI.DataAccess.Models;

public class Comment
{
    [BsonId (IdGenerator = typeof (ObjectIdGenerator))]
    public string Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string? Category { get; set; }
    public DateTime Created { get; set; }

    public List<string>? Comments = new List<string>();
    public string? Image {  get; set; }
}