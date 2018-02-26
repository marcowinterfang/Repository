using DAL.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using DAL.Context;

namespace DAL.Repository
{
    public class FriendsRepository : IRepository<Friends>, IFriendRepository, IDisposable
    {
        private MtContext mtContext;
        public FriendsRepository(MtContext mtContext)
        {
            this.mtContext = mtContext;
        }
        
        public void Add(Friends aggRoot)
        {
            if (aggRoot == null)
            {
                return;
            }
            aggRoot.CreateTimeUtc = DateTime.UtcNow;
            aggRoot.ModifyTimeUtc = DateTime.UtcNow;
            aggRoot.IsDelete = 0;
            mtContext.Friends.Add(aggRoot);
            mtContext.SaveChanges();
        }

        public void Delete(Friends aggRoot)
        {
            throw new NotImplementedException();
        }

        public bool DeleteFriend(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            mtContext = null;
        }

        public void Get(Friends aggRoot)
        {
            throw new NotImplementedException();
        }

        public Friends GetFriendById(int id)
        {
            var result = GetFriends().Where(x => x.Id == id).FirstOrDefault();
            return result;
        }

        public IEnumerable<Friends> GetFriends()
        {
            var result = mtContext.Friends.Where(x => x.IsDelete == 0);
            return result;
        }

        public void Update(Friends aggRoot)
        {
            var model = mtContext.Friends.Where(x => x.Id == aggRoot.Id).FirstOrDefault();
        }

        public bool UpdateFriend(Friends model)
        {
            if (model == null)
                return false;
            var m = mtContext.Friends.Where(x => x.Id == model.Id).FirstOrDefault();
            m = model;
            var r = mtContext.SaveChanges();
            if (r < 0)
                return false;
            return true;
        }
        
    }
}
