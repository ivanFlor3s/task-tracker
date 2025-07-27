using AutoMapper;
using TaskTracker.Application.Dto;
using TaskTracker.Domain;

namespace TaskTracker.Transversal.Mapper;

public class AppProfiler : Profile
{
    public AppProfiler()
    {
        CreateMap<CreateTaskDto, TaskItem>();
    }
}