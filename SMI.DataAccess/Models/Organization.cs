using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace SMI.DataAccess.Models;

public class Organization
{
    [BsonId (IdGenerator = typeof (ObjectIdGenerator))]
    public string Id { get; set; }
    private string _name;
    private string _email;
    private List<string> _adminIds;
    private List<string> _memberIds;
    private List<string> _issueIds;

    public Organization(string name, string email)
    {
        _name = name;
        _email = email;
        _adminIds = new List<string>();
        _memberIds = new List<string>();
        _issueIds = new List<string>();
    }
}