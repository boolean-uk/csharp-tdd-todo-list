// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using tdd_todo_list.CSharp.Main;

TodoListExtension l = new TodoListExtension();
l.Add("Task 1", "work");
l.Add("Task 2", "Coffee");
l.Add("Task 3", "Lunch");
l.Add("Task 4", "Go Home");

string time = l.GetCreationTime();
Console.WriteLine(time);

