using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Smartkey_Calculator.Models
{
    public class KeysDbContext : DbContext
    {
        public KeysDbContext()
            :base ("DefaultConnection")
        {
            Database.Initialize(false);
        }
        public DbSet<KeysModel> keyModels { get; set; }
    }
}