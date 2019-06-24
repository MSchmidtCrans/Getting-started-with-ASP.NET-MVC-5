using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogPlatform.Models
{
    public class Categorie
    {
        public int ID { get; set; }
        public string CategorieTitle { get; set; }

        public virtual Article Article { get; set; }
    }

}