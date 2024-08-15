// See https://aka.ms/new-console-template for more information
using tdd_todo_list.CSharp.Main;

Console.WriteLine("Hello, World!");
TodoList todolist = new TodoList();
Job test1 = new Job(1, "shoot", Status.INCOMPLETE, DateTime.Now);
todolist.addJob(test1);

todolist.seeJobs();
