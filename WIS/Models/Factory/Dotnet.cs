using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WIS.Models.Base;

namespace WIS.Models.Factory
{
    public abstract class Dotnet : Billet
    {
        public Dotnet()
        {
            this.LanguageID = 0;
        }
    }
}