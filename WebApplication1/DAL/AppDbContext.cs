using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Service> Services { get; set; }
        public DbSet<TeamMember> Teams { get; set; }
        public DbSet<TeamMemberPosition> Positions { get; set; }

        public DbSet<Plans> Plans { get; set; }
        public DbSet<FeatureItems> FeatureItems { get; set; }
        public DbSet<PlansFeatureItems> PlansFeatureItems { get; set; }
    }
}
