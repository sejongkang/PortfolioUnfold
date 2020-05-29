using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PortfolioUnfold.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ImageItem> ImageItems { get; set; }
        public DbSet<TextItem> TextItems { get; set; }
        public DbSet<PortfolioItem> PortfolioItems { get; set; }
    }
}