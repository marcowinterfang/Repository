using DAL.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Friends:IAggregateRoot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public DateTime? CreateTimeUtc { get; set; }
        public DateTime? ModifyTimeUtc { get; set; }
        public int IsDelete { get; set; }
    }
}
