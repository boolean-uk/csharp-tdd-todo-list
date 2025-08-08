// See https://aka.ms/new-console-template for more information
using tdd_todo_list.CSharp.Main;
using TaskItem = tdd_todo_list.CSharp.Main.TaskItem;

Console.WriteLine("Hello, World!");

TodoList todoList = new TodoList();
TaskItem t1 = new TaskItem("vaske", "vaske trapp og kjeller", 3, "husarbeid");
TaskItem t2 = new TaskItem("rydde", "rydde kjøkken", 1, "husarbeid");
TaskItem t3 = new TaskItem("lade", "lade mobilen", 1, "annet", true);
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

Console.WriteLine();
Console.WriteLine();

Console.WriteLine(t1.ToString());
t1.ChangeStatus();
Console.WriteLine(t1.ToString());

Console.WriteLine();
Console.WriteLine(todoList.DoesTaskExistByName("rydde"));

Console.WriteLine();
Console.WriteLine(todoList.GetTaskById(1));

todoList.UpdateNameById(1, "nyttNavnForTest");
todoList.PrintAllTasks();
Console.WriteLine(t1.Name);

Console.WriteLine();
Console.WriteLine(t3.ShowDateTimeOfCreation());

Console.WriteLine();
Console.WriteLine(t2.ShowDateTimeOfCompletion());
t2.ChangeStatus();
t2.ChangeStatus();
Console.WriteLine(t2.ShowDateTimeOfCompletion());