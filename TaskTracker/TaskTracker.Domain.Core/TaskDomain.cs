using TaskTracker.Domain.Interfaces;
using TaskTracker.Infraestructure.Interface;

namespace TaskTracker.Domain.Core;

public class TaskDomain: ITaskDomain
{
    private readonly IUnitOfWork _uow;

    public TaskDomain(IUnitOfWork uow)
    {
        _uow = uow;
    }

    public async Task CreateTask(TaskItem task)
    {
        await _uow.TaskRepository.AddAsync(task);
    }
}