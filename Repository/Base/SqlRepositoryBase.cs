using SimpleBot.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBot.Repository.Base
{
    public abstract class SqlRepositoryBase<TEntity, Tkey> : IRepositoryBase<TEntity, Tkey> where TEntity : BaseEntity<Tkey>
    {
        public virtual void Atualizar(TEntity entidade)
        {
            throw new NotImplementedException();
        }

        public virtual TEntity BuscaPorId(Tkey id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> BuscaTodos()
        {
            throw new NotImplementedException();
        }

        public virtual void Deletar(Tkey id)
        {
            throw new NotImplementedException();
        }

        public virtual void Inserir(TEntity entidade)
        {
            throw new NotImplementedException();
        }

        public virtual void InserirVarios(IEnumerable<TEntity> entidade)
        {
            throw new NotImplementedException();
        }
    }
}