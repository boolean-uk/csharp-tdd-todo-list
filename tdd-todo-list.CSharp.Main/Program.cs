
using tdd_todo_list.CSharp.Main;

Console.WriteLine("Console Todo app in C#\r");


TodoList todoList = new TodoList();

Console.WriteLine("TodoList");
todoList.AddTask(1, new TodoList.Task("Bread"));
todoList.AddTask(2, new TodoList.Task("Laundry"));
todoList.AddTask(3, new TodoList.Task("Clean house"));
todoList.AddTask(4, new TodoList.Task("Homework"));

todoList.ViewTodoList();