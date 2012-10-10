using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WIS.Models.Entity.Dotnet;

namespace WIS.DAL.Context
{
    public class SiteContext : DbContext
    {
            public DbSet<SnippetDotnet> SnippetDotnet { get; set; }
            public DbSet<ProjectDotnet> ProjectDotnet { get; set; }
            public DbSet<PracticeDotnet> PracticeDotnet { get; set; }

    }
}