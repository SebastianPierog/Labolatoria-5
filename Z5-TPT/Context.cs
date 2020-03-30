using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace Z5_TPT
{
    public class TPHContext: DbContext
    {
        public DbSet<Computer> Computers { get; set; }
    }
}
