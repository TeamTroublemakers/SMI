﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace SMI.DataAccess.Models;

public class User
{
    [BsonId (IdGenerator = typeof(ObjectIdGenerator))]
    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    private List<string> IssueIds { get; set; }
    private List<string> SolutionIds { get; set; }
    private List<string> CommentIds { get; set; }
    private List<string> LikeIds { get; set; }
    private List<string> OrganizationIds { get; set; }

    public User(string id, string name, string email, string password)
    {
        Id = id;
        Name = name;
        Email = email;
        Password = password;
        IssueIds = new List<string>();
        SolutionIds = new List<string>();
        CommentIds = new List<string>();
        LikeIds = new List<string>();
    }

    public User(string name, string email, string password)
    {
        Name = name;
        Email = email;
        Password = password;
    }
}