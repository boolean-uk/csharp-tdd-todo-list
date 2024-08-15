// See https://aka.ms/new-console-template for more information
using tdd_todo_list.CSharp.Main;

Console.WriteLine("Hello, World!");

TodoList list = new TodoList();
Job job1 = new Job("Do the dishes", "The dishes shall be clean, but i dont like doing the work");
Job job2 = new Job("Go for a run", "Run 1 km, its hard, but its good for you!");

list.AddToList(job1);
list.AddToList(job2);

Console.WriteLine(list.PrintJobs(list.Jobs));

