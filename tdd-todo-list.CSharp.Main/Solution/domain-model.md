# Tasks to complete

```
I want to add tasks to my todo list.
I want to see all the tasks in my todo list.
I want to change the status of a task between incomplete and complete.
I want to be able to get only the complete tasks.
I want to be able to get only the incomplete tasks.
I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
I want to remove tasks from my list.
I want to see all the tasks in my list ordered alphabetically in ascending order.
want to see all the tasks in my list ordered alphabetically in descending order.
```

| Classes     | Methods                                          | Scenario               | Outputs |
|-------------|--------------------------------------------------|------------------------|---------|
| `ToDoList`  | `bool AddTask(Task task)`                        | Adds task if task is valid  | `true` |
|             |                                                  | Unable to add task due to the task being invalid | `false`  |
|             | `bool AddTask(List<Task> tasks)`                 | Adds all valid tasks in parameter | `true` |
|             |                                                  | Unable to add all tasks if a task within the list is invalid | `false` |
|             | `bool RemoveTask(int taskID)`                    | Removes task if task with taskID is valid | `true` |
|             |                                                  | Unable to remove task if task with taskID is invalid | `false` |
|             | `bool RemoveTask(Task task)`                     | Removes all valid tasks in parameter from the list. | `true` |
|             |                                                  | Unable to remove task if task is invalid | `false` |
|             | `bool RemoveTask(List<Task> tasks)`              | Removes all tasks if all tasks are valid | `true` |
|             |                                                  | Removes all valid tasks except the invalid ones (incomplete tasks or tasks that doesn't exist within the task list)  | `false` |
|             | `void PrintTasks()`                              | Prints a list of the tasks into the console, in default input order. Includes ID, TaskInfo and TaskState | `void` |
|             |                                                  | Prints "Empty" into the console if the task list is empty | `void` |
|             | `void PrintTasks(string searchQuery = "", TaskFilterType filterQuery = TaskFilterType.NULL, TaskSortType sortBy = TaskSortType.NULL)` | Prints a list of the tasks into the console, based on the searchQuery, filter and sortType. | `void` |
|             | `bool SetTaskState(int taskID, bool isComplete)` | Updates the state of the task to the value of the isComplete parameter | `true` |
|             | `bool SetTaskState(Task task, bool isComplete)`  | Updates the state of the task to the value of the isComplete parameter | `true` |
|             | `bool GetTaskState(int taskID)`                  | Returns the task with the specified taskID if it exists | `Task` |
|             |                                                  | Returns an invalid task if task with specified taskID can not be found | `Task` (Empty) |
|             | `bool GetTaskState(Task task)`                   | Returns the specified task state if it exists | `Task` |
|             |                                                  | Returns an invalid task state if specified task does not exist within the list | `Task` (Empty) |
|             | `List<bool> GetTaskState(List<Task> task)`       | Returns a list of tasks states if tasks in the parameter exists within the list | `List<Task>` |
|             |                                                  | Returns an empty list of tasks states if none of the tasks in the parameter exists within the list | `List<Task>` (Empty) |