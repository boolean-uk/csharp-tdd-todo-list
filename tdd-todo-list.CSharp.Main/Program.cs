// See https://aka.ms/new-console-template for more information
using tdd_todo_list.CSharp.Main;

Console.WriteLine("Hello, World!");


TodoList todoList = new TodoList();

TodoList.Task task = new TodoList.Task("Call mother", false);
todoList.AddTaskToList(task, 1);
bool isInThere = todoList.ChangeStatus(1);

Console.WriteLine($"it is in there:{isInThere} and it is set to {todoList.todoList[1].complete}");