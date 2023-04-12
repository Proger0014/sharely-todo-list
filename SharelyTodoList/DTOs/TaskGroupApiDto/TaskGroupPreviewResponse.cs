namespace SharelyTodoList.DTOs.TaskGroupApiDto;

public class TaskGroupPreviewResponse
{
    public long Id { get; set; }
    public string Name { get; set; }

    public TaskGroupPreviewResponse()
    {
        Name = string.Empty;
    }
}
