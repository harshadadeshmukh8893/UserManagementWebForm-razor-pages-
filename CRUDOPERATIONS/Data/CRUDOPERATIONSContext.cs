using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDOPERATIONS.Model;

namespace CRUDOPERATIONS.Data
{
    public class CRUDOPERATIONSContext : DbContext
    {
        public CRUDOPERATIONSContext (DbContextOptions<CRUDOPERATIONSContext> options)
            : base(options)
        {
        }

        public DbSet<CRUDOPERATIONS.Model.User> User { get; set; } = default!;
    }
}
