namespace TaskTracker.Infraestructure.Interface;

public interface IGenericRepository<TEntity> where TEntity : class
{
    public Task<TEntity?> GetByIdAsync(int id);
    public Task<IEnumerable<TEntity>> GetAllAsync();
    public Task AddAsync(TEntity entity);
    public Task UpdateAsync(TEntity entity);
    public Task DeleteAsync(int id);
}