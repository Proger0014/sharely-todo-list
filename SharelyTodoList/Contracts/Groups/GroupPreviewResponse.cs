namespace SharelyTodoList.DTOs.TaskGroupApiDto;

public class GroupPreviewResponse
{
    public long Id { get; set; }
    public string Name { get; set; }

    public GroupPreviewResponse()
    {
        Name = string.Empty;
    }
}
