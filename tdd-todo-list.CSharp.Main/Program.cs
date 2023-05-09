// See https://aka.ms/new-console-template for more information
using tdd_todo_list.CSharp.Main;

Console.WriteLine("Hello, World!");

TodoList todo = new TodoList();
foreach (var s in todo.tasks)
{
    Console.WriteLine($"{s.Item1}, {s.Item2}");
}
todo.add("shopping", false);
foreach( var s  in todo.tasks )
{
    Console.WriteLine($"{s.Item1}, {s.Item2}");
}


