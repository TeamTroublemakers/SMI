using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace SMI.DataAccess.Models;

public class OrganizationUser : User
{
    [BsonId (IdGenerator = typeof (ObjectIdGenerator))]
    private string _organizationId;

    public OrganizationUser(string name, string email, string password, string organizationId) : base(name, email, password)
    {
        _organizationId = organizationId;
    }

}