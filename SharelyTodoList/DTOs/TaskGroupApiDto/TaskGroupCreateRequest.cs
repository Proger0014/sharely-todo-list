namespace SharelyTodoList.DTOs.TaskGroupApiDto;

public class TaskGroupCreateRequest
{
    public string Name { get; set; }
    public string Password { get; set; }

    public TaskGroupCreateRequest()
    {
        Name = string.Empty;
        Password = string.Empty;
    }
}
