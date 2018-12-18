namespace Todo.Repository.Implementations
{
    using System.Collections.Generic;
    using System.Data.Entity.Validation;
    using System.Linq;
    using Contracts;
    using Data;
    using Data.Contracts;
    using Data.Models;
    using Dto;
    using Dto.Enums;

    public class TaskRepository : ITaskRepository
    {
        private readonly ITodoContext _context;


        public TaskRepository(TodoContext context)
        {
            _context = context;
        }

        public TodoContext Context { get; set; }

        public List<TaskDto> GetAllTasks()
        {
            var tasks = _context.Tasks.ToList();

            var taskDto = tasks
                             .Select(t => new TaskDto()
                             {
                                 Id = t.Id,
                                 Name = t.Name,
                                 Content = t.Content,
                                 FinalDate = t.FinalDate,
                                 Importance = (ImportanceEnum)t.Importance,
                                 Status = t.Status,
                                 UserPhoto = t.UserPhoto
                             })
                             .ToList();
            return taskDto;

        }

        public void AddTask(TaskDto dto)
        {
            var task = new Task()
            {

                Name = dto.Name,
                Content = dto.Content,
                FinalDate = dto.FinalDate,
                Importance = (int)dto.Importance,
                Status = dto.Status,
                UserPhoto = dto.UserPhoto
            };

            _context.Tasks.Add(task);
            _context.SaveChanges();
        }
    }
}
