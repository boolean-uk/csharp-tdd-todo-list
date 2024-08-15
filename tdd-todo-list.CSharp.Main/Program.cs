

using tdd_todo_list.CSharp.Main;
using tdd_todo_Slist.CSharp.Main;

TodoList todoList = new TodoList();

Job job1 = new Job(1, "Vaske", Status.INCOMPLETE, DateTime.Now);

todoList.addJob(job1);

Console.WriteLine(todoList.getAllJobs());
Console.WriteLine();

todoList.changeJobStatus(job1.Id);
Console.WriteLine(job1.Status);

