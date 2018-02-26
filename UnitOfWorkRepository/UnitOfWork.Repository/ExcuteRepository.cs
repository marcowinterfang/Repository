using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Infrastructure;

namespace UnitOfWork.Repository
{
    public class ExcuteRepository : IUnitOfWorkRepository
    {
        private IUnitOfWork unitOfWork;

        public IUnitOfWork UnitOfWork
        {
            get { return unitOfWork; }
        }
        public ExcuteRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void DeleteItem(object item)
        {
            UnitOfWork.RegistRemoved(item, this);
        }

        public void NewItem(object item)
        {
            UnitOfWork.RegistAdd(item, this);
        }

        public void UpdatedItem(object item)
        {
            UnitOfWork.RegistChanged(item, this);
        }
    }
}
