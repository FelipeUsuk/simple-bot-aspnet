using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SimpleBot.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBot.Entity

{
    [BsonIgnoreExtraElements]
    public class UserProfile : BaseEntity<string>
    {
        public int Visitas { get; set; }

    }
}