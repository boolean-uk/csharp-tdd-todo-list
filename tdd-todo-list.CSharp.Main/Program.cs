using NUnit.Framework.Interfaces;
using System;
using tdd_todo_list.CSharp.Main;


TodoList toDoList = new TodoList();

TodoListExtension extension = new TodoListExtension();

toDoList.AddTask("Buy food");
toDoList.AddTask("exercise");
toDoList.AddTask("auy food");
toDoList.AddTask("cxercise");

extension.AddTask("check");

var allTasks = toDoList.ShowTasks();
Console.WriteLine(string.Join("\n", allTasks));

var idTasks = extension.FindTaskByID(1);
Console.WriteLine(string.Join("\n", idTasks));


