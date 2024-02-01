#Domain Models In Here
```
Core Requirements
I want to add tasks to my todo list.
I want to see all the tasks in my todo list.
I want to change the status of a task between incomplete and complete.
I want to be able to get only the complete tasks.
I want to be able to get only the incomplete tasks.
I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
I want to remove tasks from my list.
I want to see all the tasks in my list ordered alphabetically in ascending order.
I want to see all the tasks in my list ordered alphabetically in descending order.
```




| Classes      | Members/Attributes                               | Methods                                                      | Outputs                                                |
| ------------ | ------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------- |
| `TodoList`   | `Dictionary<string, bool>`                       | `AddTask(string task)`                                       | true if the task is added successfully, otherwise false |
|              |                                                  | `RemoveTask(int taskId)`                                     | true if the task is found and removed, otherwise false  |
|              |                                                  | `GetAllTasks()`                                              | List of all tasks in the todo list                       |  
|              |                                                  | `GetCompleteTasks()`                                         | List of complete tasks in the todo list                  |
|              |                                                  | `GetIncompleteTasks()`                                       | List of incomplete tasks in the todo list                | 
|              |                                                  | `SearchTask(string taskName)`                                | Task status message ("Not Found" or "Exists")      |   
|              |                                                  | `OrderTasksAscending()`                                      | List of tasks in alphabetical order                      |
|              |                                                  | `OrderTasksDescending()`                                     | List of tasks in descending order                         |  
|              |                                                  |                                                              |                                                         |
|              |                                                  |                                                              |                                                         |
|              |                                                  |                                                              |                                                         |
| `Task`       | `int Id`                                         | `ChangeStatus()`                                             | Task status after status changed                        |
|              | `string Name`                                    |                                                              |                                                         |
|              | `bool IsComplete`                                |                                                              |                                                         |              




```
Extension Requirements
I want to be able to get a task by a unique ID.
I want to update the name of a task by providing its ID and a new name.
I want to be able to change the status of a task by providing its ID.
I want to be able to see the date and time that I created each task.
```


| Classes      | Members/Attributes                               | Methods                                                      | Outputs                                                |
| ------------ | ------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------- |
| `TodoList`   | `Dictionary<int, Task>`                          | `AddTask(string taskName)`                                   | true if the task is added successfully, otherwise false |
|              |                                                  | `RemoveTask(int taskId)`                                     | true if the task is found and removed, otherwise false  |
|              |                                                  | `GetTaskById(int taskId)`                                     | Task object with the specified ID, or null if not found |
|              |                                                  | `UpdateTaskName(int taskId, string newName)`                 | true if the task is found and name updated, otherwise false |
|              |                                                  | `ChangeTaskStatus(int taskId)`                               | Task status after status changed                        |
|              |                                                  | `GetAllTasks()`                                              | List of all tasks in the todo list                       |  
|              |                                                  | `GetCompleteTasks()`                                         | List of complete tasks in the todo list                  |
|              |                                                  | `GetIncompleteTasks()`                                       | List of incomplete tasks in the todo list                | 
|              |                                                  | `SearchTask(string taskName)`                                | Task status message ("Not Found" or "Exists")      |   
|              |                                                  | `OrderTasksAscending()`                                      | List of tasks in alphabetical order                      |
|              |                                                  | `OrderTasksDescending()`                                     | List of tasks in descending order                         |  
|              |                                                  |                                                              |                                                         |
| `Task`       | `int Id`                                         | `ChangeStatus()`                                             | Task status after status changed                        |
|              | `string Name`                                    | `UpdateName(string newName)`                                | true if the name is updated successfully, otherwise false |
|              | `bool IsComplete`                                | `SetCreationDateTime(DateTime dateTime)`                   | true if the creation date and time are set successfully, otherwise false |
|              | `DateTime CreationDateTime`                      |                                                              |                                                         | 
