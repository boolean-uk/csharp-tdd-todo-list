using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Interfaces;

namespace tdd_todo_list.CSharp.Main;
public class TodoList
{
    public required string UUID { get; set; }

    public required string CreationDateTime { get; set; }

    public required string Title { get; set; }

    public string Description { get; set; } = string.Empty;

    public List<TodoTask> Tasks { get; set; } = new List<TodoTask>();

    public static TodoList CreateList(string Title, string Description)
    {   string UUID = Guid.NewGuid().ToString();
        Console.WriteLine($"TodoList created: " + UUID);
        return new TodoList() { UUID = UUID, CreationDateTime = DateTime.Now.ToString(), Title = Title,  Description = Description };
    }

    public TodoList GetList()
    {
        return this;
    }

    public void ReadList()
    {
        DisplayListInfo(this);
        foreach (var task in Tasks)
        {
            DisplayTaskInfo(task);
        }
    }

    public void AddTask(string Title, string Description)
    {
        string UUID = Guid.NewGuid().ToString();
        Tasks.Add(new TodoTask() { UUID = UUID, CreationDateTime = DateTime.Now.ToString(), Title = Title, Description = Description, Completed = false });
        Console.WriteLine($"Task added: " + UUID);
    }

    public void UpdateTaskStatus(string UUID, bool Completed)
    {
        foreach (var task in Tasks)
        {
            if (task.UUID == UUID)
            {
                task.Completed = Completed;
            }
        }
    }

    public List<TodoTask> GetTasksWithStatus(bool Completed)
    {
        List<TodoTask> tasksWithStatus = new List<TodoTask>();
        foreach (var task in Tasks)
        {
            if (!tasksWithStatus.Contains(task) && task.Completed == Completed)
            {
                tasksWithStatus.Add(task);
            }
        }

        return tasksWithStatus;
    }

    public List<TodoTask> GetTasks()
    {
        List<TodoTask> todoTasks = new List<TodoTask>();

        foreach (var task in Tasks)
        {
            todoTasks.Add(task);
        }

        return todoTasks;
    }

    public void DeleteTask(string UUID)
    {
        foreach (var task in Tasks)
        {
            if (task.UUID == UUID)
            {
                Tasks.Remove(task);
                Console.WriteLine("Task has been removed!");
                return;
            }
        }
    }

    public List<TodoTask> GetSortedTasks(string sort = "")
    {
        List<TodoTask> list = GetTasks();

        if (sort == "alfasc")
        {
            list = list.OrderBy(t => t.Title).ToList();
        }

        if (sort == "alfdec")
        {
            list = list.OrderBy(t => t.Title).ToList();
            list.Reverse();
        }

        if (sort == "dateasc")
        {
            list = list.OrderBy(t => t.CreationDateTime).ToList();
        }

        if (sort == "datedec")
        {
            list = list.OrderBy(t => t.CreationDateTime).ToList();
            list.Reverse();
        }

        return list;
    }

    public TodoTask? GetTask(string UUID)
    {
        foreach (var task in Tasks)
        {
            if (task.UUID == UUID)
            {
                return task;
            }
        }
        Console.WriteLine("Task not found!");
        return null;
    }

    public void ReadTask(string UUID)
    {
        foreach (var task in Tasks)
        {
            if (task.UUID == UUID)
            {
                DisplayTaskInfo(task);
                return;
            }
        }
    }

    public void DisplayListInfo(TodoList todoList)
    {
        Console.WriteLine($"\n- LIST -" + "\nUUID: " + todoList.UUID + "\nCreationDateTime: " + todoList.CreationDateTime + "\nTitle: " + todoList.Title + "\nDescription: " +  todoList.Description + "\n-\n");
    }

    public void DisplayTaskInfo(TodoTask task)
    {
        Console.WriteLine($"- TASK -" + "\nUUID: " + task.UUID + "\nCreationDateTime: " + task.CreationDateTime + "\nTitle: " + task.Title + "\nDescription: " + task.Description + "\nCompleted: " + task.Completed.ToString() + "\n-\n");
    }
}

public class TodoTask
{
    public required string UUID { get; set; }

    public required string CreationDateTime { get; set; }

    public required string Title { get; set; }

    public string Description { get; set; } = string.Empty;

    public required bool Completed { get; set; } = false;
}