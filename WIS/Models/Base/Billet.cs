using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WIS.Models.Base
{
    public abstract class Billet
    {
        public int ID { get; set; }
        public int LanguageID { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }
    }
}