// See https://aka.ms/new-console-template for more information
using tdd_todo_list.CSharp.Main;

Console.WriteLine("Hello, World!");

TodoList todoList = new TodoList();

Console.WriteLine(todoList.viewTasks());
Console.WriteLine("---------");
Console.WriteLine(todoList.viewCompletedTasks());
Console.WriteLine(todoList.viewIncompletedTasks());
Console.WriteLine(todoList.UpdateTask("Dishes"));
Console.WriteLine(todoList.UpdateTask("Laundry"));
Console.WriteLine(todoList.RemoveTask("Grocery Shopping"));
Console.WriteLine("---------");

Console.WriteLine(todoList.viewTasks());

Console.WriteLine(todoList.SearchTask("Laundry"));

Console.WriteLine("---------");

Console.WriteLine(todoList.SortAscTask());
Console.WriteLine(todoList.SortDescTask());



