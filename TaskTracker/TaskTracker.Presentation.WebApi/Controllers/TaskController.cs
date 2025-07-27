using Microsoft.AspNetCore.Mvc;
using TaskTracker.Application.Dto;
using TaskTracker.Application.Interface;

namespace TaskTracker.Presentation.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TaskController : ControllerBase
{

    private readonly ITaskApplication _taskApplication;
    
    public TaskController(ITaskApplication taskApplication)
    {
        _taskApplication = taskApplication;
    }
    
    [HttpGet]
    public IActionResult GetTasks()
    {
        return Ok(new { Message = "List of tasks" });
    }

    [HttpPost]
    public async Task<IActionResult> CreateTask([FromBody] CreateTaskDto task)
    {
        await _taskApplication.CreateTaskAsync(task);
        return CreatedAtAction(nameof(CreateTask), new { id = 1 }, task); // Example response
        
    }
    
}