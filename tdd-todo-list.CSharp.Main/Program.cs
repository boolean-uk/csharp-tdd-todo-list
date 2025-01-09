using System;
using tdd_todo_list.CSharp.Main;

public class Program
{
    public static void Main(string[] args)
    {
        TodoList todoList = TodoList.CreateList("Title1", "Description1");

        // I want to add tasks to my todo list.
        Console.WriteLine("\n# I want to add tasks to my todo list.");
        todoList.AddTask("A", "A");
        todoList.AddTask("B", "B");
        todoList.AddTask("C", "C");

        TodoTask task1 = todoList.Tasks[0];
        TodoTask task2 = todoList.Tasks[1];
        TodoTask task3 = todoList.Tasks[2];

        // I want to see all the tasks in my todo list.
        Console.WriteLine("\n# I want to see all the tasks in my todo list.");
        todoList.ReadList();

        // I want to change the status of a task between incomplete and complete.
        Console.WriteLine("\n# I want to change the status of a task between incomplete and complete.");
        todoList.UpdateTaskStatus(task1.UUID, true);
        todoList.DisplayTaskInfo(task1);

        // I want to be able to get only the complete tasks.
        Console.WriteLine("\n# I want to be able to get only the complete tasks.");
        List<TodoTask> completedTasks = todoList.GetTasksWithStatus(true);
        foreach (TodoTask task in completedTasks)
        {
            todoList.DisplayTaskInfo(task);
        }

        // I want to be able to get only the incomplete tasks.
        Console.WriteLine("\n# I want to be able to get only the incomplete tasks.");
        List<TodoTask> incompletedTasks = todoList.GetTasksWithStatus(false);
        foreach (TodoTask task in incompletedTasks)
        {
            todoList.DisplayTaskInfo(task);
        }

        // I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
        Console.WriteLine("\n# I want to search for a task and receive a message that says it wasn't found if it doesn't exist.");
        TodoTask? exist = todoList.GetTask(task1.UUID);
        TodoTask? not_exist = todoList.GetTask("UUID");

        // I want to remove tasks from my list.
        Console.WriteLine("\n# I want to remove tasks from my list.");
        todoList.DeleteTask(task1.UUID);

        // I want to see all the tasks in my list ordered alphabetically in ascending order.
        Console.WriteLine("\n# I want to see all the tasks in my list ordered alphabetically in ascending order.");
        List<TodoTask> alfasc = todoList.GetSortedTasks("alfasc");
        foreach (TodoTask task in alfasc)
        {
            todoList.DisplayTaskInfo(task);
        }

        // I want to see all the tasks in my list ordered alphabetically in descending order.
        Console.WriteLine("\n# I want to see all the tasks in my list ordered alphabetically in descending order.");
        List<TodoTask> alfdec = todoList.GetSortedTasks("alfdec");
        foreach (TodoTask task in alfdec)
        {
            todoList.DisplayTaskInfo(task);
        }

        // I want to be able to get a task by a unique ID.
        Console.WriteLine("\n# I want to see all the tasks in my list ordered alphabetically in descending order.");
        Console.WriteLine("Already done in core.");

        // I want to update the name of a task by providing its ID and a new name.
        Console.WriteLine("\n# I want to update the name of a task by providing its ID and a new name.");
        TodoListExtension todoExtensionList = TodoListExtension.CreateList("A", "A");
        todoExtensionList.AddTask("B", "B");
        todoExtensionList.UpdateTaskTitle(todoList.Tasks[0].UUID, "C");
        todoList.DisplayTaskInfo(todoExtensionList.Tasks[0]);

        // I want to be able to change the status of a task by providing its ID.
        Console.WriteLine("\n# I want to be able to change the status of a task by providing its ID.");
        Console.WriteLine("Already done in core.");

        // I want to be able to see the date and time that I created each task.
        Console.WriteLine("\n# I want to be able to see the date and time that I created each task.");
        Console.WriteLine("Already done in core.");

    }
}
