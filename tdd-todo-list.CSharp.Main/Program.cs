// See https://aka.ms/new-console-template for more information
using tdd_todo_list;
using tdd_todo_list.CSharp.Main;

Console.WriteLine("Hello, World!");
tdd_todo_list.Task task = new tdd_todo_list.Task("Do groceries");
tdd_todo_list.Task task2 = new tdd_todo_list.Task("Clean");

TodoList todoList = new TodoList();
todoList.AddTask(task);
todoList.AddTask(task2);
todoList.ShowTasks();