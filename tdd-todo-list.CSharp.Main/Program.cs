using System;
using tdd_todo_list.CSharp.Main;


TodoList toDoList = new TodoList();

toDoList.AddTask("Buy food");
toDoList.AddTask("exercise");

toDoList.ShowTasks();

toDoList.RemoveTask("Buy food");

toDoList.ShowTasks();
