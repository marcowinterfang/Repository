using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Infrastructure
{
    public interface IUnitOfWorkRepository
    {
        void NewItem(object item);
        void UpdatedItem(object item);
        void DeleteItem(object item);
    }
}
