// See https://aka.ms/new-console-template for more information
using tdd_todo_list.CSharp.Main;

TodoList todo = new TodoList();
TodoListExtension ext = new TodoListExtension();
ToDoTask t = new ToDoTask(1, "Shower", false);

Console.WriteLine(t);

ext.AddTask(1, "dishes", false);

Console.WriteLine(ext.getTaskById(1));
