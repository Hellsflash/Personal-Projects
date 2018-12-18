namespace Todo.Repository.Contracts
{
    using System.Collections.Generic;
    using Dto;

    public interface ITaskRepository
    {
        List<TaskDto> GetAllTasks();

        void AddTask(TaskDto dto);
    }
}