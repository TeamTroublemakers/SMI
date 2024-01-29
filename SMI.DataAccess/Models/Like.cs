using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace SMI.DataAccess.Models;

public class Like
{
    [BsonId(IdGenerator = typeof(ObjectIdGenerator))]
    public string Id { get; set; }

    private string _userId;
    private string _issueId;
    private string? _solutionId;
    private string? _commentId;

    public Like(string userId, string issueId)
    {
        _userId = userId;
        _issueId = issueId;
    }

    //public Like(string userId, string solutionId)
    //{
    //    _id = userId;
    //    _userId = userId;
    //    _solutionId = solutionId;
    //}

    //public Like(string userId, string commentId)
    //{
    //    _id = userId;
    //    _userId = userId;
    //    _commentId = commentId;
    //}
}