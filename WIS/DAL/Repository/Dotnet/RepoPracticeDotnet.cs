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

    public class RepoPracticeDotnet : IRepoPracticeDotnet
    {
        SiteContext _context = new SiteContext();

        /// <summary>
        ///  ajoute une entité PracticeDotnet à la base de donnée
        /// </summary>
        /// <param name="entity"></param>
        public void Create(PracticeDotnet entity)
        {
            _context.PracticeDotnet.Add(entity);
        }

        /// <summary>
        /// Récupère la liste des entités PracticeDotnet depuis base de donnée
        /// </summary>
        /// <returns></returns>
        public IQueryable<PracticeDotnet> Request()
        {
            return _context.PracticeDotnet;
        }

        /// <summary>
        /// Met à jour l'entité PracticeDotnet dans la base de donnée
        /// </summary>
        /// <param name="entity"></param>
        public void Update(PracticeDotnet entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Efface l'entité PracticeDotnet de la base de donnée
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(PracticeDotnet entity)
        {
            _context.PracticeDotnet.Remove(entity);
        }

        /// <summary>
        ///  Recupère l'entite PracticeDotnet à partir de son Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PracticeDotnet Get(int id)
        {
          return _context.PracticeDotnet.Find(id);
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