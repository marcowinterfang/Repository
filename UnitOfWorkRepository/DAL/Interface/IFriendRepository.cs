using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Aggregate
{
    public interface IFriendRepository:IRepository<Friends>
    {
        IEnumerable<Friends> GetFriends();
        bool UpdateFriend(Friends model);
        bool DeleteFriend(int id);
        Friends GetFriendById(int id);
    }
}
