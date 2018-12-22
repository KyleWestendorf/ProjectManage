using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ProjectManageDAL
{
    public class Context : DbContext
    {
        public DbSet<Project> Projects { get; set; }
    }
}