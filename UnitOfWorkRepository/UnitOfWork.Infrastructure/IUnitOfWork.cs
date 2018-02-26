using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Infrastructure
{
    public interface IUnitOfWork
    {
        void RegistAdd(object entity, IUnitOfWorkRepository repository);
        void RegistChanged(object entity, IUnitOfWorkRepository repository);
        void RegistRemoved(object entity, IUnitOfWorkRepository repository);
        void Commit();
    }
}
