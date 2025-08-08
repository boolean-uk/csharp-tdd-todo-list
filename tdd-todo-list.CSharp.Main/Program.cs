// See https://aka.ms/new-console-template for more information
using NUnit.Framework;
using tdd_todo_list.CSharp.Main;
using Type = tdd_todo_list.CSharp.Main.Type;

TodoList ToDoList = new TodoList();

ToDoList.Add("1", Type.Admin);
ToDoList.Add("2", Type.Admin);
ToDoList.Add("3", Type.Study);
ToDoList.Add("4", Type.Work);
ToDoList.getById(1).TimeCreated = DateTime.Now.AddMinutes(-4);
ToDoList.getById(2).TimeCreated = DateTime.Now.AddMinutes(-5);
ToDoList.getById(3).TimeCreated = DateTime.Now.AddMinutes(-6);
ToDoList.getById(4).TimeCreated = DateTime.Now.AddMinutes(-7);

ToDoList.getById(1).markAsFinished();
ToDoList.getById(2).markAsFinished();
ToDoList.getById(3).markAsFinished();
ToDoList.getById(4).markAsFinished();
ToDoTask shortestOpen = ToDoList.ShortestBeforeFinished();

Console.WriteLine(shortestOpen.Name);

ToDoList.Add("5", Type.Work);
ToDoList.getById(5).TimeCreated = DateTime.Now.AddMinutes(-10);

shortestOpen = ToDoList.ShortestBeforeFinished();

Console.WriteLine(shortestOpen.Name);



