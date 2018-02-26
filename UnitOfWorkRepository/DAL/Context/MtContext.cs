using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class MtContext:DbContext
    {
        public MtContext():base("name=MarcoTest")
        {

        }
        public DbSet<Friends> Friends { get; set; }
    }
}
