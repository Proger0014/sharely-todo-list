﻿namespace SharelyTodoList.Models.TaskGroup;

public class TaskGroup
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }

    public TaskGroup()
    {
        Name = string.Empty;
        Password = string.Empty;
    }
}
