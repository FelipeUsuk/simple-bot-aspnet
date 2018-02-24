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
    public class Message : BaseEntity<string>
    {
        public string Usuario { get; set; }
        public string Texto { get; set; }

        public Message(string id, string username, string text)
        {
            this.EntityId = id;
            this.Usuario = username;
            this.Texto = text;
        }

      
    }
}