using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace SMI.DataAccess.Models;

public class Solution
{
    [BsonId (IdGenerator = typeof (ObjectIdGenerator))]
    public string Id { get; set; }
}