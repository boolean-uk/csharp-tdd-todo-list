// See https://aka.ms/new-console-template for more information
using tdd_todo_list.CSharp.Main;

Console.WriteLine("Hello, World!");

TodoList a =  new TodoList();
PTask task = new PTask("Apple sauce");


a.AddTask(task);