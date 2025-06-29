
using System.ComponentModel.DataAnnotations;
using TaskTracker.Core.Entities.Bases;

namespace TaskTracker.Core.Entities;

public class TaskItem : AuditEntity
{
  public int Id {get;set;}
  [MaxLength(30)]
  public required string Title {get;set;}
  public required string Description {get;set;}
  public int TagId {get;set;}
  public required Tag Tag {get;set;}
}
