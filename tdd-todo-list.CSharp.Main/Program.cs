// See https://aka.ms/new-console-template for more information
using tdd_todo_list.CSharp.Main;
using TaskItem = tdd_todo_list.CSharp.Main.TaskItem;

Console.WriteLine("Hello, World!");

TodoList todoList = new TodoList();
TaskItem t1 = new TaskItem(1,"vaske", "vaske trapp og kjeller", 3, "husarbeid");
TaskItem t2 = new TaskItem(2, "rydde", "rydde kjøkken", 1, "husarbeid");
TaskItem t3 = new TaskItem(3, "lade", "lade mobilen", 1, "annet", "complete");
todoList.AddTask(t1);
todoList.AddTask(t2);
todoList.AddTask(t3);

todoList.PrintAllTasks();

todoList.GetAllTasksInOrder();
todoList.PrintAllTasks();

todoList.PrintListOfTasks(todoList.GetCompletedTasks());
Console.WriteLine();

Console.WriteLine(todoList.GetTaskById(1));

todoList.UpdateNameById(1, "nyttNavn");

Console.WriteLine();
todoList.PrintAllTasks();