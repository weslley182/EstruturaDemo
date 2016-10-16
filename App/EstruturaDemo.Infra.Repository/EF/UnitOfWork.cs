using System.Data.Entity;
using EstruturaDemo.Domain.Interfaces;
using Microsoft.Practices.ServiceLocation;

namespace EstruturaDemo.Infra.Repository.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext _context;

        public void BeginTransaction()
        {
            var  contextManager = ServiceLocator.Current.GetInstance<ContextManager>();
            _context = contextManager.Context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
