# Domain Model 

# User Stories:

As a user, I want to add a new task to my Todo List.
As a user, I want to mark a task as complete.
As a user, I want to mark a completed task as incomplete.
As a user, I want to view all tasks in my Todo List.
As a user, I want to view only completed tasks.
As a user, I want to view only incomplete tasks.
As a user, I want to search for a task by its title.
As a user, I want to remove a task from my Todo List.
As a user, I want to get tasks ordered in ascending alphabetical order.
As a user, I want to get tasks ordered in descending alphabetical order.
As a user, I want to get a task by its ID.
As a user, I want to update the name of a task.
As a user, I want to change the status of a task.

| Class               | Method                                            | Scenario                                                                       | Expected Output                                                           |
|---------------------|---------------------------------------------------|--------------------------------------------------------------------------------|---------------------------------------------------------------------------|
| `TodoList`          | `AddTask(TodoItem item)`                          | User wants to add a new task to the Todo List.                                 | Task is added to the Todo List.                                           |
| `TodoList`          | `UpdateTaskStatus(taskId: int, isComplete: bool)` | User wants to mark a task as completed.                                        | Task's status is updated to "completed".                                  | 
| `TodoList`          | `UpdateTaskStatus(taskId: int, isComplete: bool)` | User wants to mark a completed task as incomplete.                             | Task's status is updated to "incomplete".                                 |
| `TodoList`          | `GetAllTasks()`                                   | User wants to view a list of all tasks in the Todo List.                       | List of all tasks is displayed.                                           |
| `TodoList`          | `GetCompletedTasks()`                             | User wants to view a list of completed tasks in the Todo List.                 | List of completed tasks is displayed.                                     |
| `TodoList`          | `GetIncompleteTasks()`                            | User wants to view a list of incomplete tasks in the Todo List.                | List of incomplete tasks is displayed.                                    |
| `TodoList`          | `SearchTask(title: string)`                       | User wants to search for a task in the Todo List.                              | Task with a matching title is displayed, or "Task not found" is returned. |
| `TodoList`          | `RemoveTask(TodoItem item)`                       | User wants to remove a task from the Todo List.                                | Task is removed from the Todo List.                                       |
| `TodoList`          | `TasksAscendingOrder()`                           | User wants to view tasks in ascending order of their titles.                   | List of tasks is displayed in ascending order.                            |
| `TodoList`          | `TasksDescendingOrder()`                          | User wants to view tasks in descending order of their titles.                  | List of tasks is displayed in descending order.                           |
| `TodoListExtension` | `GetTaskById(id: int)`                            | User wants to retrieve a task by its ID.                                       | Task with the specified ID is returned.                                   |
| `TodoListExtension` | `UpdateTaskName(taskId: int, newName: string)`    | User wants to update the name of a task using an extension method.             | Task's name is updated to the new name.                                   |
| `TodoListExtension` | `UpdateTaskStatus(taskId: int, isComplete: bool)` | User wants to mark a task as complete or incomplete using an extension method. | Task's status is updated accordingly using an extension method.           |