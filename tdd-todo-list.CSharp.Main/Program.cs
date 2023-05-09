// See https://aka.ms/new-console-template for more information
using tdd_todo_list.CSharp.Main;

Console.WriteLine("Hello, World!");

TodoList todo = new TodoList();
foreach (var item in todo.tasks)
{
    Console.WriteLine(item);
}
todo.changedStatus(2);
foreach (var item in todo.tasks)
{
    Console.WriteLine(item);
}




