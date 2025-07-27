using AutoMapper;
using TaskTracker.Application.Dto;
using TaskTracker.Application.Interface;
using TaskTracker.Domain;
using TaskTracker.Domain.Interfaces;

namespace TaskTracker.Application.Main;

public class TaskApplication: ITaskApplication
{

    private readonly IMapper _mapper;
    private readonly ITaskDomain _taskDomain;

    public TaskApplication(IMapper mapper, ITaskDomain taskDomain)
    {
        _mapper = mapper;
        _taskDomain = taskDomain;
    }

    public async Task CreateTaskAsync(CreateTaskDto input)
    {
        var task = _mapper.Map<CreateTaskDto, TaskItem>(input);
        await _taskDomain.CreateTask(task);
    }
}