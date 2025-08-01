using Microsoft.EntityFrameworkCore;
using TaskTracker.Domain;
using TaskTracker.Infraestructure.Data;
using TaskTracker.Infraestructure.Interface;

namespace TaskTracker.Infraestructure.Repository;

public class TaskRepository(AppDbContext dbContext) : GenericRepository<TaskItem>(dbContext), ITaskRepository;