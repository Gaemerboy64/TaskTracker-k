namespace TaskTracker.TaskDomain;

public class TaskItem
    //we're going to hard code these ids
    // but we should revisit this and have the class own
    // incrementing the id for uniqueness
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool IsComplete { get; set; }
}