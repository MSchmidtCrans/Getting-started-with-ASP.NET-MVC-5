using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogPlatform.Models
{
    public class ArticleDBContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<ListCategorie> ListCategories { get; set; }
    }    
    
    public class Article
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string ArticleText { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual ICollection<Categorie> Categories { get; set; }
    }
}