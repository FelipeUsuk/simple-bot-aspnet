using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using SimpleBot.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBot.Repository.MongoRepositories
{
    
    public class UserProfileRepository : MongoRepositoryBase<UserProfile, string>
    {
        private static readonly Lazy<UserProfileRepository> lazy =
         new Lazy<UserProfileRepository>(() => new UserProfileRepository());

        public static UserProfileRepository Instance { get { return lazy.Value; } }

        private UserProfileRepository()
        {
            cliente = new MongoClient();
            db = cliente.GetDatabase("Bot");
            col = db.GetCollection<UserProfile>("UserProfile");
        }

        public override void InserirAsync(UserProfile entidade)
        {
            col.InsertOne(entidade);
        }

        public override void InserirVarios(IEnumerable<UserProfile> entidade)
        {
            throw new NotImplementedException();
        }

        public override void InserirVariosAsync(IEnumerable<UserProfile> entidade)
        {
            throw new NotImplementedException();
        }

        public override UserProfile BuscaPorId(string id)
        {
            try
            {
                var filtro = Builders<UserProfile>.Filter.Eq("EntityId", id);
                var resultado = col.Find(filtro).ToList().First();
                return resultado;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public override void Atualizar(UserProfile entidade)
        {
            var filtro = Builders<UserProfile>.Filter.Eq("EntityId", entidade.EntityId);
            col.ReplaceOne(filtro,entidade);
        }
    }
}