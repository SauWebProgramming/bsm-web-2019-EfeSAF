namespace WebProje.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebProje.Models.DataContext.KDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        ////protected override void Seed(WebProje.Models.DataContext.KDBContext context)
        ////{
        ////    //  This method will be called after migrating to the latest version.

        ////    //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
        ////    //  to avoid creating duplicate seed data.
        //}
    }
}
