using tdd_todo_list.CSharp.Main;

TodoList todoList = new TodoList();

tdd_todo_list.CSharp.Main.Task task = new("Feed the dog", false);
tdd_todo_list.CSharp.Main.Task task2 = new("Feed the cat", true);
tdd_todo_list.CSharp.Main.Task task3 = new("Feed the horse", false);
tdd_todo_list.CSharp.Main.Task task4 = new("Feed the fish", true);
todoList.addTaskToList(task);
todoList.addTaskToList(task2);
todoList.addTaskToList(task3);
todoList.addTaskToList(task4);

Console.WriteLine("Initial list: ");
todoList.displayList();
Console.WriteLine("By ascending order: ");
todoList.orderByAscending();
todoList.displayList();
Console.WriteLine("By descending order: ");
todoList.orderByDescending();
todoList.displayList();
Console.WriteLine("Filter by completed: ");
todoList.completedTasks().ForEach(task => { Console.WriteLine($"Task: {task.description}"); });
Console.WriteLine("Filter by uncompleted: ");
todoList.uncompletedTasks().ForEach(task => { Console.WriteLine($"Task: {task.description}"); });
Console.WriteLine("Remove 'Feed the dog' ");
todoList.removeTaskFromList(task);
todoList.displayList();
Console.WriteLine("Check if 'feed the horse exists' and show task description");
Console.WriteLine(todoList.search("Feed the horse"));
Console.WriteLine("Set 'Feed the horse to be completed'");
todoList.changeCompleteStatus(task3);
todoList.displayList();




