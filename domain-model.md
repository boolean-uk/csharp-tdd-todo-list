# Domain Model

|Classes|Method/Properties|Scenario|Outputs|
|-------|-----------------|--------|-------|
|`TodoList`|`AddTask(string name)`|Add task with name to todo list| int ID of new task|
|`TodoList`|`GetAllTasks()`|Provide all tasks in todo list | List<Task> |
|`Task`| `ToggleComplete()` | Toggle status from complete to incomplete or incomplete to complete| bool |
|`TodoList`| `GetCompleteTasks()`| Provide all complete tasks in todo list | List<Task>|
|`TodoList`| `GetIncompleteTasks()`| Provide all incomplete tasks in todo list | List<Task>|
|`TodoList`| `GetTaskByName(string name)`| Search for Task with given name | List<Task>, provide message if not found |
|`TodoList`| `RemoveTask(string name)` | Remove task with given name from TodoList | bool |
|`TodoList`| `GetAllTasksSortedByName(bool useAscendingOrder)` | Return sorted version of tasks by name, either ascending or descending alphabetical order, to user | Sorted List<Task>|
|`TodoList`| `GiveTaskPriority(name)` | Add priority (low, medium, high) to a given task | string current priority |
|`TodoList`| `SortTasksByPriority()` | Return sorted version of tasks sorted by priority | Sorted List<Taks> |
|`TodoList`| `GetTaskByID(int id)` | Provide task with given id | Task |
|`TodoList`| `UpdateTaskName(int id, string newName)` | Update the name of a task with given id | bool |
|`TodoList`| `UpdateTaskStatus(int id)` | Toggle the status of task with given ID | bool |
|`TodoList`| `GetAllTaskTimeCreated()` | Provide all tasks along with time of creation | (List<Task>, datetime) |
|`TodoList`| `GetAllTaskTimeCompleted()` | Provide all tasks along with time of completion | (List<Task>, datetime) |
|`TodoList`| `GetTaskWithLongestCompletionTime()` | Provide the task with the longest completion time | (<Task>, completion time) |
|`TodoList`| `GetTaskWithShortestCompletionTime()` | Provide the task with the shortest completion time | (<Task>, completion time) |
|`TodoList`| `GetTasksByCompletionTime(int numDaysToComplete)` | Provide all tasks with completion time longer than given time | List<Task> |
|`Task`| `SetTaskCategory(string name, string category)` | Set category of task | bool |
|`TodoList`| `GetTasksByCategory(string category)` | Get all tasks matching the given category | List<Task> | 