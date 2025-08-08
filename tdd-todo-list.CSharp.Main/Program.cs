// See https://aka.ms/new-console-template for more information
using tdd_todo_list.CSharp.Main;
using Type = tdd_todo_list.CSharp.Main.Type;

TodoList ToDoList = new TodoList();

ToDoList.Add("1", Type.Admin);
ToDoList.Add("2", Type.Admin);
ToDoList.Add("3", Type.Study);
ToDoList.Add("4", Type.Work);
ToDoList.Add("5", Type.Work);

ToDoList.getById(1).markAsFinished();
Thread.Sleep(1000);
ToDoList.getById(2).markAsFinished();
Thread.Sleep(1000);
ToDoList.getById(3).markAsFinished();
Thread.Sleep(1000);
ToDoList.getById(4).markAsFinished();
Thread.Sleep(6000);

ToDoList.Todo.Values.ToList().ForEach(t => Console.WriteLine(t.TimeSpan));
Console.WriteLine(ToDoList.LongestBeforeFinished().Name);


