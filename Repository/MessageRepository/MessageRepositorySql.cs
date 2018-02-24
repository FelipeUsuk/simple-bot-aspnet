using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;
using SimpleBot.Entity;
using SimpleBot.Repository.Base;
using SimpleBot.Repository.MessageRepository;

namespace SimpleBot.Repository.MongoRepositories
{
    public class MessageRepositorySql : SqlRepositoryBase<Message, string>, IMessageRepository
    {
        private static readonly Lazy<MessageRepositorySql> lazy =
         new Lazy<MessageRepositorySql>(() => new MessageRepositorySql());

        public static MessageRepositorySql Instance { get { return lazy.Value; } }
        
        private MessageRepositorySql()
        {

        }

        public override void InserirVarios(IEnumerable<Message> entidade)
        {
            throw new NotImplementedException();
        }

        public override Message BuscaPorId(string id)
        {
            throw new NotImplementedException();
        }

        public override void Atualizar(Message entidade)
        {
            throw new NotImplementedException();
        }
    }
}