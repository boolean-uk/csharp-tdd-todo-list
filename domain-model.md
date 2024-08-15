# Domain Model

`I want to add tasks to my todo list.
I want to see all the tasks in my todo list.
I want to change the status of a task between incomplete and complete.
I want to be able to get only the complete tasks.
I want to be able to get only the incomplete tasks.
I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
I want to remove tasks from my list.
I want to see all the tasks in my list ordered alphabetically in ascending order.
I want to see all the tasks in my list ordered alphabetically in descending order.`

| **Classes** | **Members** | **Methods** | **Scenario** | **Outputs** |
|:--:|:--:|:--:|:--:|:--:|
| `ToDoList` | `List<Task>` | `AddToList(Task)` | Add task to ToDoList | `bool` |
| `ToDoList` | `List<Task>` | `PrintTasks()` | View all tasks in ToDoList | `Console` |
| `Task` | `Complete` | `ChangeStatus(status)` | Changing status of task to complete | `Console` |
| `Task` | `Complete` | `ChangeStatus(status)` | Changing status of task to incomplete | `Console` |
| `ToDoList` | `List<Task>` | `GetTasks(status)` | Get tasks that is complete | `List<Task>` |
| `ToDoList` | `List<Task>` | `GetTasks(status)` | Get tasks that is incomplete | `List<Task>` |
| `ToDoList` | `List<Task>` | `GetTask(name)` | Get existing task specified by name | `Task` |
| `ToDoList` | `List<Task>` | `RemoveTask(name)` | Remove existing task from ToDoList | `bool` |
| `ToDoList` | `List<Task>` | `RemoveTask(name)` | Remove non existing task from ToDoList | `bool` |
