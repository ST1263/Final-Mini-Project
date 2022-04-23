using Microsoft.EntityFrameworkCore;
using ProjectNS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectNS.Data
{
    public class NSDbContext : DbContext
    {
        public NSDbContext(DbContextOptions<NSDbContext> options) : base(options)
        {

        }
        public DbSet<RecallType> RecallType { get; set; }
        public DbSet<FDAClassification> FDAClassification { get; set; }
        public DbSet<RecallCategories> RecallCategories { get; set; }
        public DbSet<RecallInfo> RecallInfo { get; set; }
    }
}
