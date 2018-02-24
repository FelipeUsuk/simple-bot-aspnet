using MongoDB.Driver;
using SimpleBot.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBot.Repository
{
    public abstract class MongoRepositoryBase<TEntity, Tkey> :  IRepositoryBase<TEntity, Tkey> where TEntity : BaseEntity<Tkey>
    {
        protected IMongoCollection<TEntity> col;
        protected IMongoDatabase db;
        protected MongoClient cliente;

        public virtual void Atualizar(TEntity entidade)
        {
            throw new NotImplementedException();
        }

        public virtual TEntity BuscaPorId(Tkey id)
        {
            try
            {
                var filtro = Builders<TEntity>.Filter.Eq("EntityId", id);
                var resultado = col.Find(filtro).ToList().First();
                return resultado;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public virtual IEnumerable<TEntity> BuscaTodos()
        {
            throw new NotImplementedException();
        }

        public void Deletar(Tkey id)
        {
            throw new NotImplementedException();
        }

        public virtual void Inserir(TEntity entidade)
        {
            col.InsertOne(entidade);
        }

        public virtual void InserirAsync(TEntity entidade)
        {
            throw new NotImplementedException();
        }

        public virtual void InserirVarios(IEnumerable<TEntity> entidade)
        {
            throw new NotImplementedException();
        }

        public virtual void InserirVariosAsync(IEnumerable<TEntity> entidade)
        {
            throw new NotImplementedException();
        }
    }
}