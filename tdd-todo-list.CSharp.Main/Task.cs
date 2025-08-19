namespace tdd_todo_list.CSharp.Main;

public class Task
{
    public readonly string Name;
    public string Description;
    public TaskStatus Status;
    public TaskPriority Priority;

    public Task(string name, string description, TaskStatus status = TaskStatus.Incomplete, TaskPriority priority = TaskPriority.Low)
    {
        Name = name;
        Description = description;
        Status = status;
        Priority = priority;
    }
    
    public bool Equals(Task other)
    {
        return Name == other.Name;
    }
}