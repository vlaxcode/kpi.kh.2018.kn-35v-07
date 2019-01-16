using Lab4_Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Data
{
    public class Context : DbContext
    {
        public Context()
            : base("ResponseConnection")
        {
        }

        public DbSet<Response> Responses { get; set; }
    }
}
