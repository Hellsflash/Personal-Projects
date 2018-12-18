namespace Todo.Data.Contracts
{
    using System.Data.Entity;
    using Models;

    public interface ITodoContext
    {
        DbSet<Task> Tasks { get; set; }

        int SaveChanges();
    }
}