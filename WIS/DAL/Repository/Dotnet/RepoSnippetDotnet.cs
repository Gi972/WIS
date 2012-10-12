using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WIS.DAL.Context;
using WIS.Models.Entity.Dotnet;
using WIS.DAL.Repository.Interfaces.Dotnet;
using System.Data;

namespace WIS.DAL.Repository.Dotnet
{
    // On implémente les requêtes personalisés ici
    public class RepoSnippetDotnet<T> : IRepoSnippetDotnet where T : SnippetDotnet
    {

        SiteContext _context = new SiteContext();

        /// <summary>
        /// ajoute une entité snippetDotnet à la base de donnée
        /// </summary>
        /// <param name="entity"></param>
        public void Create(SnippetDotnet entity)
        {
            _context.SnippetDotnet.Add(entity);
        }

        /// <summary>
        /// Récupère la liste des entités snippetDotnet depuis base de donnée
        /// </summary>
        /// <returns></returns>
        public IQueryable<SnippetDotnet> Request()
        {
            return _context.SnippetDotnet;
        }

        /// <summary>
        /// Met à jour l'entité SnippetDontnet dans la base de donnée
        /// </summary>
        /// <param name="entity"></param>
        public void Update(SnippetDotnet entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Efface l'entité SnippetDotnet de la base de donnée
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(SnippetDotnet entity)
        {
            _context.SnippetDotnet.Remove(entity);
        }

        /// <summary>
        /// Recupère l'entite SnippetDotnet à partir de son Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SnippetDotnet Get(int id)
        {
            return _context.SnippetDotnet.Find(id);
        }


        /// <summary>
        /// Sauvegarde la persitence en base de données
        /// </summary>
        public void SaveChanges()
        {
            _context.SaveChanges();
        }


       
    }
}