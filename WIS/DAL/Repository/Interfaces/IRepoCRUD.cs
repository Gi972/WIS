using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WIS.DAL.Repository.Interfaces
{
    // [Interface de base pour toute classe voulant implémenter des actions CRUD]

    public interface IRepoCRUD<T> where T :class
    {
        //Create / Ajouter
        void Create(T entity);

        //Recuperer
        IQueryable<T> Request ();
       
        //Update / Mettre à jour
        void Update(T entity);
      
        //Delete /Supprimer
        void Delete(T entity);

        // [----Suppléments----]
        
        //Recuperer par Id
        T Get(int id);

        //Sauvegarde la persistence
        void SaveChanges();

    }
}