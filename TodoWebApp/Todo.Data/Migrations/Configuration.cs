namespace Todo.Data.Migrations
{
  
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Todo.Data.TodoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Todo.Data.TodoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
