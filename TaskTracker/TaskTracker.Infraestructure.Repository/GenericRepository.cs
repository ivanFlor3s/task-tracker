using Microsoft.EntityFrameworkCore;
using TaskTracker.Infraestructure.Data;
using TaskTracker.Infraestructure.Interface;

namespace TaskTracker.Infraestructure.Repository;

public class GenericRepository<T>: IGenericRepository<T> where T : class
{
    private readonly AppDbContext context;
    public GenericRepository(AppDbContext context)
    {
        this.context = context ?? throw new ArgumentNullException(nameof(context));
        if (!context.Set<T>().Any())
        {
            throw new InvalidOperationException($"The DbSet for {typeof(T).Name} is not initialized.");
        }
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        return await context.Set<T>().FindAsync(id);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await context.Set<T>().ToListAsync();
    }

    public async Task AddAsync(T entity)
    {
        await context.Set<T>().AddAsync(entity);
        
        
    }

    public Task UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
            context.Set<T>().Remove(entity);
        else
            throw new KeyNotFoundException($"Entity with id {id} not found.");
    }
}