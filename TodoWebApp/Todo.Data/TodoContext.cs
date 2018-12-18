namespace Todo.Data
{
    using System.Data.Entity;
    using Contracts;
    using Models;

    public class TodoContext:DbContext,ITodoContext
    {
        public TodoContext():base("TodoContext")
        {          
        }

       public DbSet<Task> Tasks { get; set; }
    }
}