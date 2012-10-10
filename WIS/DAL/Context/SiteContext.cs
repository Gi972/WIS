using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WIS.Models.Entity.Dotnet;
using WIS.Models.Entity;
using WIS.Migrations;

namespace WIS.DAL.Context
{
    public class SiteContext : DbContext
    {

        public DbSet<Language> Language { get; set; }
        public DbSet<SnippetDotnet> SnippetDotnet { get; set; }
        public DbSet<ProjectDotnet> ProjectDotnet { get; set; }
        public DbSet<PracticeDotnet> PracticeDotnet { get; set; }

        //TODO Je n'implemente pas la partie ruby pas nécéssaire pour l'instant 
        public SiteContext()
            : base("webindiedtbase")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SiteContext, Configuration>());
        }
    }
}