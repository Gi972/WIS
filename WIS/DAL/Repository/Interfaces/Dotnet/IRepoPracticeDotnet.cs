using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WIS.Models;
using WIS.Models.Entity.Dotnet;

namespace WIS.DAL.Repository.Interfaces.Dotnet
{
    // Les interfaces de requête hérite de l'interface CRUD qui contient les requêtes de base 

    public interface IRepoPracticeDotnet : IRepoCRUD<PracticeDotnet>
    {

    }
}