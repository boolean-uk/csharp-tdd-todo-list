namespace tdd_todo_list.CSharp.Main;

public class ExtendedTask
{
    public readonly Guid Id;
    public readonly DateTime CreateTime;
    public TaskStatus Status { get; private set; }
    public DateTime? CompleteTime { get; private set; }
    
    public string Name;
    public string Description;

    public ExtendedTask(string name, string description)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        Status = TaskStatus.Incomplete;
        CreateTime = DateTime.Now;
    }

    public void Complete()
    {
        if (Status == TaskStatus.Complete) return;
        Status = TaskStatus.Complete;
        CompleteTime = DateTime.Now;
    }

    public bool Equals(Task other)
    {
        return Name == other.Name;
    }
}