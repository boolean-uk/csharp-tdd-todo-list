// See https://aka.ms/new-console-template for more information
using tdd_todo_list.CSharp.Main;

Console.WriteLine("Hello, World!");


TodoList core = new TodoList();

core.AddTask(new TodoTask("sdfsdf"));

foreach (var item in core.Tasks)
{
    Console.WriteLine(item.Taskname);
}