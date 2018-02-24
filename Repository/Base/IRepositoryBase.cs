using MongoDB.Driver;
using SimpleBot.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SimpleBot.Repository
{
    public interface IRepositoryBase<TEntity, Tkey> where TEntity : BaseEntity<Tkey>
    {
        void Inserir(TEntity entidade);
        void InserirVarios(IEnumerable<TEntity> entidade);
        TEntity BuscaPorId(Tkey id);

        IEnumerable<TEntity> BuscaTodos();
        void Atualizar(TEntity entidade);
        void Deletar(Tkey id);
    }
}