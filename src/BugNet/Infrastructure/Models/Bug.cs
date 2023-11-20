using System.ComponentModel.DataAnnotations;

namespace BugNet.Infrastructure.Models;
public class Bug
{
    public int Id { get; set; }

    [Length(3, 30)]
    public required string Name { get; set; }

    [Length(10, 1000)]
    public required string Description { get; set; }
    public bool IsDone { get; set; }

    //public BugState State { get; set; }

    //public DateTime TimeCreated { get; set; }

    //public DateTime TimeUpdated { get; set; }
}

public enum BugState
{
    Todo = 0,
    InProgress = 1,
    Done = 2
}