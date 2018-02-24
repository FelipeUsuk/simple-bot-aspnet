using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBot.Entity
{
    public abstract class BaseEntity<Tkey>
    {
        public Tkey EntityId { get; set; }

  
    }
}