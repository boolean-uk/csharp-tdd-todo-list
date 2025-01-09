using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main;

public class TodoListExtension
{
    public required string UUID { get; set; }

    public required string CreationDateTime { get; set; }

    public required string Title { get; set; }

    public string Description { get; set; } = string.Empty;

    public List<TodoTask> Tasks { get; set; } = new List<TodoTask>();

    public static TodoListExtension CreateList(string Title, string Description)
    {
        string UUID = Guid.NewGuid().ToString();
        Console.WriteLine($"TodoList created: " + UUID);
        return new TodoListExtension() { UUID = UUID, CreationDateTime = DateTime.Now.ToString(), Title = Title, Description = Description };
    }

    public void AddTask(string Title, string Description)
    {
        string UUID = Guid.NewGuid().ToString();
        Tasks.Add(new TodoTask() { UUID = UUID, CreationDateTime = DateTime.Now.ToString(), Title = Title, Description = Description, Completed = false });
        Console.WriteLine($"Task added: " + UUID);
    }

    public void UpdateTaskTitle(string UUID, string newTitle)
    {
        foreach (var task in Tasks)
        {
            if (task.UUID == UUID)
            {
                task.Title = newTitle;
            }
        }
    }
}
