using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WIS.DAL.Repository.Interfaces.Dotnet;
using WIS.Models.Entity.Dotnet;
using WIS.DAL.Context;
using System.Data;

namespace WIS.DAL.Repository.Dotnet
{
    // On implémente les requêtes personalisés ici
    public class RepoProjectDotnet : IRepoProjectDotnet
    {
        SiteContext _context = new SiteContext();

        /// <summary>
        /// ajoute une entité ProjectDotnet à la base de donnée
        /// </summary>
        /// <param name="entity"></param>
        public void Create(ProjectDotnet entity)
        {
            _context.ProjectDotnet.Add(entity);
        }

        /// <summary>
        /// Récupère la liste des entités ProjectDotnet depuis base de donnée
        /// </summary>
        /// <returns></returns>
        public IQueryable<ProjectDotnet> Request()
        {
            return _context.ProjectDotnet;
        }

        /// <summary>
        /// Met à jour l'entité ProjectDotnet dans la base de donnée
        /// </summary>
        /// <param name="entity"></param>
        public void Update(ProjectDotnet entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Efface l'entité ProjectDotnet de la base de donnée
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(ProjectDotnet entity)
        {
            _context.ProjectDotnet.Remove(entity);
        }

        /// <summary>
        ///  Recupère l'entite ProjectDotnet à partir de son Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ProjectDotnet Get(int id)
        {
          return  _context.ProjectDotnet.Find(id);
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