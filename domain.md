| Classes         | Methods                                                     | Scenario                                   | Outputs              |
|-----------------|-------------------------------------------------------------|--------------------------------------------|----------------------|
| `TodoList`      | `AddTask(task: TodoTask)`                                   | Add a new task to the todo list.           | -                    |
| `TodoList`      | `GetTasks(): List<TodoTask>`                                | Retrieve all tasks from the todo list.     | List of tasks        |
| `TodoList`      | `GetTasksOrderedAlphabeticallyDescending(): List<TodoTask>` | Retrieve tasks ordered alphabetically in descending order. | List of tasks in descending order |
| `TodoList`      | `SearchTaskById(taskId: int): TodoTask`                     | Search for a task by its ID.               | Found task or null   |
| `TodoList`      | `RemoveTaskById(taskId: int): TodoTask`                     | Remove a task from the todo list by ID.    | Removed task or null |
