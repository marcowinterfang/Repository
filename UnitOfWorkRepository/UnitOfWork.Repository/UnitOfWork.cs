using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using UnitOfWork.Infrastructure;

namespace UnitOfWork.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private Dictionary<object, IUnitOfWorkRepository> addEntities;
        private Dictionary<object, IUnitOfWorkRepository> updateEntities;
        private Dictionary<object, IUnitOfWorkRepository> deleteEntities;
        public UnitOfWork()
        {
            addEntities = new Dictionary<object, IUnitOfWorkRepository>();
            updateEntities = new Dictionary<object, IUnitOfWorkRepository>();
            deleteEntities = new Dictionary<object, IUnitOfWorkRepository>();
        }
        public void RegistAdd(object entity, IUnitOfWorkRepository repository)
        {
            this.addEntities.Add(entity, repository);
        }

        public void RegistChanged(object entity, IUnitOfWorkRepository repository)
        {
            this.updateEntities.Add(entity, repository);
        }

        public void RegistRemoved(object entity, IUnitOfWorkRepository repository)
        {
            this.deleteEntities.Add(entity, repository);
        }

        public void Commit()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                foreach (var entity in addEntities.Keys)
                {
                    this.addEntities[entity].NewItem(entity);
                }
                foreach (var entity in updateEntities.Keys)
                {
                    this.updateEntities[entity].UpdatedItem(entity);
                }
                foreach (var entity in deleteEntities.Keys)
                {
                    this.deleteEntities[entity].DeleteItem(entity);
                }
                scope.Complete();
            }
            this.addEntities.Clear();
            this.updateEntities.Clear();
            this.deleteEntities.Clear();
        }
    }
}
