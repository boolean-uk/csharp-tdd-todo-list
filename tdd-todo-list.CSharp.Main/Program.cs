// See https://aka.ms/new-console-template for more information
using tdd_todo_list.CSharp.Main;

Console.WriteLine("Hello, World!");



TodoList core = new TodoList();
string task1 = "Clean Room";
string task2 = "Solve space-time continueum";
string task3 = "Do homework";
string task4 = "Beat Melania in Elden Ring";

core.Add(task1);
core.Add(task2);
core.Add(task3);
core.Add(task4);
List<string> list = core.ShowAlphabeticalList();

Console.WriteLine(core.ShowIncomplete());

foreach (string item in list)
{
    Console.WriteLine(item);
}