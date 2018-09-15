namespace NHL.Migrations
{
    using NHL.Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NHL.Data.NhlContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NHL.Data.NhlContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Players.AddOrUpdate(p => new { p.FirstName, p.LastName }, InitialData.getPlayers(context).ToArray());
        }
    }
}
