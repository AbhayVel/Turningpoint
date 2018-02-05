using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TurningPoint.Entities;

namespace TurningPoint.DAO
{
    public class TurningPointContext:DbContext
    {
        public TurningPointContext() : base("TurningPointConnection")
        {

        }
        public DbSet<User> User { get; set; }
    }
}
