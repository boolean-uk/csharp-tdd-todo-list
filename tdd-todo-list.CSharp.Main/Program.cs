using NUnit.Framework.Interfaces;
using System;
using tdd_todo_list.CSharp.Main;


TodoList toDoList = new TodoList();

toDoList.AddTask("Buy food");
toDoList.AddTask("exercise");
toDoList.AddTask("auy food");
toDoList.AddTask("cxercise");

var allTasks = toDoList.ShowTasks();
Console.WriteLine(string.Join("\n", allTasks));


