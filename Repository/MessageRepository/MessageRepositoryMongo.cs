using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;
using SimpleBot.Entity;
using SimpleBot.Repository.MessageRepository;

namespace SimpleBot.Repository.MongoRepositories
{
    public class MessageRepositoryMongo : MongoRepositoryBase<Message, string>, IMessageRepository
    {
        private static readonly Lazy<MessageRepositoryMongo> lazy =
         new Lazy<MessageRepositoryMongo>(() => new MessageRepositoryMongo());

        public static MessageRepositoryMongo Instance { get { return lazy.Value; } }



        private MessageRepositoryMongo()
        {
            cliente = new MongoClient();
            db = cliente.GetDatabase("Bot");
            col = db.GetCollection<Message>("MensagensBot");
        }

        public override void InserirAsync(Message entidade)
        {
            throw new NotImplementedException();
        }

        public override void InserirVarios(IEnumerable<Message> entidade)
        {
            throw new NotImplementedException();
        }

        public override void InserirVariosAsync(IEnumerable<Message> entidade)
        {
            throw new NotImplementedException();
        }

    
     
        public override Message BuscaPorId(string id)
        {
            var filtro = Builders<Message>.Filter.Eq("EntityId:", id);
            var resultado = col.Find(filtro).ToList().First();
            return resultado;
        }

        public override void Atualizar(Message entidade)
        {
            throw new NotImplementedException();
        }
    }
}