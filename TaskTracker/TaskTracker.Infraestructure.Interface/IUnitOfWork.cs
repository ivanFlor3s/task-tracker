namespace TaskTracker.Infraestructure.Interface;

public interface IUnitOfWork: IDisposable
{
    public ITaskRepository TaskRepository { get; }
}