using TaskTracker.Infraestructure.Interface;

namespace TaskTracker.Infraestructure.Repository;

public class UnitOfWork(ITaskRepository taskRepository) : IUnitOfWork
{
    public ITaskRepository TaskRepository { get; } = taskRepository;
    
    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}