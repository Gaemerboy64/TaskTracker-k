namespace TaskTracker.TaskDomain;

public class TaskItem
    //we're going to hard code these ids
    // but we should revisit this and have the class own
    // incrementing the id for uniqueness
{
    private static int _totalCount = 0;

    public static int TotalCount
    {
        get => _totalCount;
    }
    public TaskItem()
    {
        ++_totalCount;
    }
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool IsComplete { get; set; }
}