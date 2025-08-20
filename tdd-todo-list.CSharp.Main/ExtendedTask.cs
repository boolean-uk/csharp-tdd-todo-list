namespace tdd_todo_list.CSharp.Main;

public class ExtendedTask
{
    public readonly Guid Id;
    public readonly DateTime CreateTime;
    public TaskStatus Status { get; private set; }
    public DateTime? CompleteTime { get; private set; }


    public string Name;
    public TaskCategory Category;

    public ExtendedTask(string name, int completionDays = -1)
    {
        Id = Guid.NewGuid();
        Name = name;
        CreateTime = DateTime.Now;
        Category = TaskCategory.Work;

        if (completionDays == -1)
        {
            Status = TaskStatus.Incomplete;
        }
        else
        {
            Status = TaskStatus.Complete;
            CompleteTime = DateTime.Now;
            CompleteTime = CompleteTime?.AddDays(completionDays);
        }
    }

    public TimeSpan? GetDuration()
    {
        return CompleteTime - CreateTime;
    }

    public void Complete()
    {
        if (Status == TaskStatus.Complete) return;
        Status = TaskStatus.Complete;
        CompleteTime = DateTime.Now;
    }

    public bool Equals(ExtendedTask other)
    {
        return Name == other.Name;
    }
}