using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebProje.Models.Model;


namespace WebProje.Models.DataContext
{
    public class KDBContext:DbContext //classların db de gösterilmesi için yapılan class.
    {
        public KDBContext():base("KurumsalWebDB")
        {

              
        }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Hakkimizda> Hakkimizda { get; set; }
        public DbSet<Hizmet> Hizmet { get; set; }
        public DbSet<Iletisim> Iletisim { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Kimlik> Kimlik { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<KDBContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}