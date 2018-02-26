using DAL.Context;
using DAL.Model;
using DAL.Repository;
using System;
using System.Linq;

namespace UnitOfWork.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //DAL.Context.MtContext mt = new DAL.Context.MtContext();
            //var list = from f in mt.Friends
            //           select f;
            //if(list.Count()>0)
            //    System.Console.WriteLine("not null");
            MtContext mtContext = new MtContext();
            FriendsRepository fr = new FriendsRepository(mtContext);
            Friends f = new Friends();
            f.Name = "Pearl";
            f.Title = "Sily";
            fr.Add(f);
            System.Console.ReadKey();
        }
    }
}
