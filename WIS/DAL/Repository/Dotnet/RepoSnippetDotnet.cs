using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WIS.DAL.Context;
using WIS.Models.Entity.Dotnet;

namespace WIS.DAL.Repository.Dotnet
{
    public class RepoSnippetDotnet
    {
        SiteContext _context = new SiteContext();

        public void Add(SnippetDotnet snippet) {

            _context.SnippetDotnet.Add(snippet);
            _context.SaveChanges();
        }

        public List<SnippetDotnet> List()
        {
            return _context.SnippetDotnet.ToList();
        }
    }
}