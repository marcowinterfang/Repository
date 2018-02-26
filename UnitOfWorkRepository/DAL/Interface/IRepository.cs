using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Aggregate
{
    public interface IRepository<TAggregateRoot>:IDisposable
        where TAggregateRoot:class,IAggregateRoot
    {
        void Add(TAggregateRoot aggRoot);
        void Update(TAggregateRoot aggRoot);
        void Delete(TAggregateRoot aggRoot);
        void Get(TAggregateRoot aggRoot);
    }
}
