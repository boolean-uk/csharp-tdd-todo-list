using tdd_todo_list.CSharp.Main.tdd_todo_list.CSharp.Main;


TodoListExtension todoList = new TodoListExtension();

while(true)
{
    Console.WriteLine("Please enter a command:");
    string command = Console.ReadLine();

    switch(command)
    {
        case "add":
            Console.WriteLine("Enter task name:");
            string taskName = Console.ReadLine();
            todoList.AddTask(taskName);
            Console.WriteLine($"Task '{taskName}' added.");
            break;

        case "list":
            foreach(var task in todoList.tasks)
            {
                Console.WriteLine($"ID: {task.Id}, Name: {task.Name}, IsComplete: {task.IsComplete}, CreatedAt: {task.CreatedAt}");
            }
            break;

        case "change":
            Console.WriteLine("Enter task ID:");
            string taskId = Console.ReadLine();
            Console.WriteLine("Enter new status (true for complete, false for incomplete):");
            bool newStatus = bool.Parse(Console.ReadLine());
            todoList.ChangeTaskStatus(Guid.Parse(taskId) , newStatus);
            Console.WriteLine($"Task status changed.");
            break;

        case "exit":
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Unknown command. Please try again.");
            break;
    }
}


