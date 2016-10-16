using EstruturaDemo.Domain.Interfaces;
using EstruturaDemo.Infra.Repository.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDemo.Infra.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected EstruturaContext Context { get; private set; }

        public RepositoryBase()
        {
            Context = new EstruturaContext();
        }

        public void Add(TEntity obj)
        {
            Context.Set<TEntity>().Add(obj);
        }        

        public void Delete(TEntity obj)
        {
            Context.Set<TEntity>().Remove(obj);
        }

        public void Delete(int id)
        {
            var obj = Get(id);
            Delete(obj);
        }

        public TEntity Get(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> Get()
        {
            return Context.Set<TEntity>().ToList();
        }

        public void Update(TEntity obj)
        {
            Context.Entry(obj).State = EntityState.Modified;
        }
    }
}
