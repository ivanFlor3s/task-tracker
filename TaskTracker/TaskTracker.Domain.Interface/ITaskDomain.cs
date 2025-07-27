namespace TaskTracker.Domain.Interfaces;

public interface ITaskDomain
{
    public Task CreateTask(TaskItem task);
}