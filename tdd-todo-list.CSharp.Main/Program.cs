using tdd_todo_list.CSharp.Main;
using Task = tdd_todo_list.CSharp.Main.Task;
using TaskStatus = tdd_todo_list.CSharp.Main.TaskStatus;

TodoList list = new TodoList();
list.addTask("Task 1", "Desc 1", TaskPriority.Medium, TaskCategory.Admin);

bool changedToComplete = list.setStatus(0, TaskStatus.Complete);

List<Task> completes = list.getAllTasks(TaskStatus.Complete);
completes.ForEach(t => Console.WriteLine(t));
