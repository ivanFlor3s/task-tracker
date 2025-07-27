using TaskTracker.Application.Dto;

namespace TaskTracker.Application.Interface;

public interface ITaskApplication
{
    public Task CreateTaskAsync(CreateTaskDto input);
}