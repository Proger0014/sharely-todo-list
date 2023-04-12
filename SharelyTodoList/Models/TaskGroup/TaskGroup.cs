namespace SharelyTodoList.Models.TaskGroup;

public class TaskGroup
{
    public long Id { get; set; }
    public string Name { get; set; }

    public TaskGroup()
    {
        Name = string.Empty;
    }
}
